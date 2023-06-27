namespace DataAccessLibrary.DataAccess
{
	public interface ICustomerSessionData
	{
		DateTime GetAppointmentDate();
		int GetAppointmentID();
		string GetAppointmentNumberPlate();
		void SetAppointmentDateTime(DateTime newAppointmentDate);
		void SetAppointmentID(int newAppointmentID);
		void SetAppointmentNumberPlate(string newAppointmentNumberPlate);
	}
}