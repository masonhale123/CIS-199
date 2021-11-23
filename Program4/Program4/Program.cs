/* Grading ID: R1738
 * Program 4
 * 12/02/2020
 * CIS 190-01
 * This is an application with two classes. One will be the application where the main method is located, automatically generated. The other will be a class of our creation to represent a Service Order. 
 * This class represents an Order for Service that a repair technician may carry out at an appliance repair company.
 */
using System;

namespace Program4
{
    class Program
    {
        class ServiceOrder
        {
            public ServiceOrder(int ServiceLocationZipCode, string ModelNumber, string SerialNumber, int AppointmentLength, string TechnicianName, bool WarrantyCoverage)
            {
                this.ServiceLocationZipCode = ServiceLocationZipCode;
                this.ModelNumber = ModelNumber;
                this.SerialNumber = SerialNumber;
                this.AppointmentLength = AppointmentLength;
                this.TechnicianName = TechnicianName;
                this.WarrantyCoverage = WarrantyCoverage;
            }
            string ModelNumber, SerialNumber, TechnicianName;
            int ServiceLocationZipCode, AppointmentLength;
            bool WarrantyCoverage;
            double Cost;

            void setServiceLocationZipCode(int ServiceLocationZipCode)
            {
                if (ServiceLocationZipCode <= 99999 && ServiceLocationZipCode >= 00000)
                    this.ServiceLocationZipCode = ServiceLocationZipCode;
                else
                    this.ServiceLocationZipCode = 40204;
            }

            int getServiceLocationZipCode()
            {
                return ServiceLocationZipCode;
            }

            void setStrings(string ModelNumber, string SerialNumber, string TechnicianName)
            {
                if (ModelNumber.Length == 5)
                    this.ModelNumber = ModelNumber;
                if (SerialNumber.Length == 10)
                    this.SerialNumber = SerialNumber;
                if (!(String.IsNullOrWhiteSpace(TechnicianName)))
                    this.TechnicianName = TechnicianName;
            }

            string getStrings()
            {
                return "\nModel Number: " + ModelNumber + "\tSerial Number: " + SerialNumber + "\tTechnician Name: " + TechnicianName;
            }

            void setAppointmentLength(int AppointmentLength)
            {
                if (AppointmentLength >= 15 && AppointmentLength <= 180)
                    this.AppointmentLength = AppointmentLength;
            }

            int getAppointmentLength()
            {
                return AppointmentLength;
            }

            void setWarrantyCoverage(bool WarrantyCoverage)
            {
                this.WarrantyCoverage = WarrantyCoverage;
            }

            bool getWarrantyCoverage()
            {
                return WarrantyCoverage;
            }

            double CalcCost()
            {
                if (WarrantyCoverage == false)
                    Cost = 25 + 1.50 * AppointmentLength;
                else
                    Cost = 20;
                return Cost;
            }

            public new string ToString()
            {
                return "Service Location Zip Code: " + ServiceLocationZipCode + "\nModel Number: " + ModelNumber + "\nSerial Number: " + SerialNumber + "\nAppointment Length: " + AppointmentLength + " minutes\nAppointment Hours: " + AppointmentLength / 60 + " Hours\nTechnician Name: " + TechnicianName + "\nWarranty Coverage: " + WarrantyCoverage;
            }
            public static void DisplayServiceOrder(ServiceOrder[] obj)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    //Console.WriteLine("\nService number: "+(i+1));
                    Console.WriteLine("\n");
                    Console.WriteLine(obj[i].ToString());
                    Console.WriteLine("Calculate Cost Output: " + obj[i].CalcCost());
                }
            }

            static void Main()
            {
                ServiceOrder[] obj = new ServiceOrder[6];
                obj[0] = new ServiceOrder(40207, "A4734", "C123456789", 40, "John Smith", true);
                obj[1] = new ServiceOrder(40059, "A9843", "C123456789", 50, "Bob Jones", false);
                obj[2] = new ServiceOrder(40214, "A7432", "C123456789", 120, "Monica Fitzgerald", true);
                obj[3] = new ServiceOrder(40222, "A9872", "C123456789", 140, "John Smith", false);
                obj[4] = new ServiceOrder(40207, "A8973", "C123456789", 130, "John Smith", true);
                obj[5] = new ServiceOrder(40214, "A7232", "C123456789", 40, "Bob Jones", false);
                ServiceOrder.DisplayServiceOrder(obj);

                obj[0].setStrings("A4734", "C123456789", "John Smith");
                obj[1].setAppointmentLength(200);
                obj[2].setServiceLocationZipCode(123456);
                obj[3].setWarrantyCoverage(true);
                obj[4].setStrings("A8973", "C123456789", null);
                obj[5].setAppointmentLength(130);
                Console.WriteLine("\nUpdated Information: ");
                ServiceOrder.DisplayServiceOrder(obj);

            }
        }
    }
}