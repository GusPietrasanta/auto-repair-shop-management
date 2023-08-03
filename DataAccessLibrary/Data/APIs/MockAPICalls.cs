using DataAccessLibrary.Models;
using System.Text.Json.Nodes;
using System.Xml;

namespace DataAccessLibrary.Data.APIs
{
	public class MockApiCalls : IApiCalls
	{
		public IVehicleModel GetVehicleDetails(string numberPlate)
		{
            IVehicleModel output = new VehicleModel();

            string path;

            string fullPath;
            
            if (Environment.GetEnvironmentVariable("RUNNING_IN_AZURE") == "true")
            {
	            fullPath = Path.Combine("wwwroot", "DataAccessLibrary", "Data", "APIs", "TestXMLs");
            }
            else if (Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") == "true")
            {
	            fullPath = Path.Combine("DataAccessLibrary", "Data", "APIs", "TestXMLs");
            }
            else
            {
	            string currentDirectory = Directory.GetCurrentDirectory();

	            path = Directory.GetParent(currentDirectory)!.ToString();
	            
	            fullPath = Path.Combine(path, "DataAccessLibrary", "Data", "APIs", "TestXMLs");
            }

            string filePath = Path.Combine(fullPath, $"{numberPlate}.xml");

			string parsedJson = "";

			try
			{
				XmlTextReader reader = new XmlTextReader(filePath);

				while (reader.Read())
				{
					if (reader.Name == "vehicleJson")
					{
						reader.Read();
						parsedJson = reader.Value;
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
			output.Make = vehicleInfoNode!["CarMake"]!["CurrentTextValue"]!.GetValue<string>();
			output.Model = vehicleInfoNode["ModelDescription"]!["CurrentTextValue"]!.GetValue<string>();
			output.Year = vehicleInfoNode["extended"]!["year"]!.GetValue<string>();
			output.Vin = vehicleInfoNode["VechileIdentificationNumber"]!.GetValue<string>();
			output.SizeLitres = vehicleInfoNode["extended"]!["capacityValue"]!.GetValue<string>();
			output.Cylinders = vehicleInfoNode["extended"]!["cylinders"]!.GetValue<string>();
			output.EngineDescription = vehicleInfoNode["extended"]!["engineDescription"]!.GetValue<string>();
			output.BodyType = vehicleInfoNode["extended"]!["bodyType"]!.GetValue<string>();
			output.TransmissionType = vehicleInfoNode["extended"]!["transmissionType"]!.GetValue<string>();
			output.FuelType = vehicleInfoNode["extended"]["fuelType"]!.GetValue<string>();

			return output;
		}
	}
}
