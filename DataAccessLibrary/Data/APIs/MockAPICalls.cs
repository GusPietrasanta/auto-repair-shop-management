using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Nodes;
using System.Xml;

namespace DataAccessLibrary.Data.APIs
{
	public class MockAPICalls : IAPICalls
	{
		public IVehicleModel GetVehicleDetails(string numberPlate)
		{
            IVehicleModel output = new VehicleModel();

			string path = Directory.GetCurrentDirectory();

            path = Directory.GetParent(path).ToString();

			path = $"{path}\\DataAccessLibrary\\Data\\APIs\\TestXMLs";

			string filePath = $"{path}\\{numberPlate}.xml";

			string parsedJson = "";

			try
			{
				XmlTextReader reader = new XmlTextReader(filePath);

				while (reader.Read())
				{
					if (reader.Name == "vehicleJson")
					{
						reader.Read();
						parsedJson = reader.Value.ToString();
						break;
					}
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}

			JsonNode vehicleInfoNode = JsonNode.Parse(parsedJson);

			output.NumberPlate = numberPlate;
			output.Make = vehicleInfoNode["CarMake"]!["CurrentTextValue"]!.GetValue<string>();
			output.Model = vehicleInfoNode["ModelDescription"]!["CurrentTextValue"]!.GetValue<string>();
			output.Year = vehicleInfoNode["extended"]!["year"]!.GetValue<string>();
			output.VIN = vehicleInfoNode["VechileIdentificationNumber"]!.GetValue<string>();
			output.SizeLitres = vehicleInfoNode["extended"]!["capacityValue"]!.GetValue<string>();
			output.Cylinders = vehicleInfoNode["extended"]!["cylinders"]!.GetValue<string>();
			output.EngineDescription = vehicleInfoNode["extended"]!["engineDescription"]!.GetValue<string>();
			output.BodyType = vehicleInfoNode["extended"]!["bodyType"]!.GetValue<string>();
			output.TransmissionType = vehicleInfoNode["extended"]!["transmissionType"]!.GetValue<string>();

			if (output.EngineDescription.ToLower().Contains("diesel"))
			{
				output.FuelType = "Diesel";
			}
			else if (output.EngineDescription.ToLower().Contains("petrol"))
			{
				output.FuelType = "Petrol";
			}
			else
			{
				output.FuelType = "Unknown";
			}

			return output;
		}
	}
}
