// namespace TrainReserves.reserves
// {
//     public class ChairsType
//     {        
//         const int AllChairs = 100;
//         const int ExecutiveChairs = 20;
//         const int EconomicChairs = 80;
//         const int ExecutiveClassChair = 1;
//         const int ExecutiveWindowChair = 10;
//         const int ExecutiveCorridorChair = 10;
//         const int EconomicWindowChair = 40;
//         const int EconomicCorridorChair = 40;
//         const int WindowPreference = 1;
//         const string EconomicClass = "Economica";
//         const string ExecutiveClass = "Ejecutiva";
//         const string WindowPreferenceChair = "Ventana";
//         const string CorridorPreferenceChair = "Pasillo";
        
//         private static int ActualEconomic = 0;
//         private static int ActualExecutive = 0;
//         private static int ActualExecutiveWindowChair = 0;
//         private static int ActualExecutiveCorridorChair = 0;
//         private static int ActualEconomicWindowChair = 0;
//         private static int ActualEconomicCorridorChair = 0;
//         public string SelectedClassChair { get; private set; }
//         public string SelectedPreferenceChair { get; private set; }

//         public void AddReserve(int chairClass, int chairPreference)
//         {            
//             if (chairClass == ExecutiveClassChair)
//             {
//                 ActualExecutive = ActualExecutive + 1;
//                 SelectedClassChair = ExecutiveClass;
//                 if (chairPreference == WindowPreference)
//                 {
//                     ActualExecutiveWindowChair = ActualExecutiveWindowChair + 1;
//                     SelectedPreferenceChair = WindowPreferenceChair;
//                 }
//                 else
//                 {
//                     ActualExecutiveCorridorChair = ActualExecutiveCorridorChair + 1;
//                     SelectedPreferenceChair = CorridorPreferenceChair; 
//                 }
//             }
//             else
//             {
//                 ActualEconomic = ActualEconomic + 1;
//                 SelectedClassChair = EconomicClass;
//                 if (chairPreference == WindowPreference)
//                 {
//                     ActualEconomicWindowChair = ActualEconomicWindowChair + 1;
//                     SelectedPreferenceChair = WindowPreferenceChair; 
//                 }
//                 else 
//                 {
//                     ActualEconomicCorridorChair = ActualEconomicCorridorChair + 1; 
//                     SelectedPreferenceChair = CorridorPreferenceChair; 
//                 }
//             }
//         }

//         public void RemoveReserveSpace(string chairClass, string chairPreference)
//         {
//             if (chairClass == ExecutiveClass)
//             {
//                 ActualExecutive = ActualExecutive - 1;
//                 if (chairPreference == WindowPreferenceChair)
//                 {
//                     ActualExecutiveWindowChair = ActualExecutiveWindowChair - 1;
//                 }
//                 else
//                 {
//                     ActualExecutiveCorridorChair = ActualExecutiveCorridorChair - 1;
//                 }
//             }
//             else
//             {
//                 ActualEconomic = ActualEconomic - 1;
//                 if (chairPreference == WindowPreferenceChair)
//                 {
//                     ActualEconomicWindowChair = ActualEconomicWindowChair - 1; 
//                 }
//                 else 
//                 {
//                     ActualEconomicCorridorChair = ActualEconomicCorridorChair - 1; 
//                 }
//             }
//         }

//         public int TrainOccupation()
//         {
//             var ActualOccupation = ActualEconomic + ActualExecutive;
//             var result = 0;
//             if (ActualOccupation != 0)
//             {
//                 result = (ActualOccupation / AllChairs) * 100;
//             }
//             return result;
//         }

//         public string ValidateClassAndPreference(int chairClass, int chairPreference)
//         {
//             if (chairClass == ExecutiveClassChair && ActualExecutive == ExecutiveChairs)
//             {
//                 return "Ya no se cuenta con sillas disponibles en la clase Ejecutiva.";
//             }
//             else if (ActualEconomic == EconomicChairs)
//             {
//                 return "Ya no se cuenta con sillas disponibles en la clase Economica.";
//             }
//             return validatePreference(chairClass, chairPreference);
//         }

//         private string validatePreference(int chairClass, int chairPreference)
//         {
//             switch (chairClass)
//             {
//                 case 1:
//                     if(chairPreference == WindowPreference && ActualExecutiveWindowChair == ExecutiveWindowChair)
//                     {
//                         return "No se tiene disponibles sillas en la ventana para clase ejecutiva.";
//                     }
//                     else if (ActualExecutiveCorridorChair == ExecutiveCorridorChair) 
//                     {
//                         return "No se tiene disponible sillas en el corredor para clase ejecutiva.";
//                     }
//                     return "";
//                 case 2:   
//                     if(chairPreference == WindowPreference && ActualEconomicWindowChair == EconomicWindowChair)
//                     {
//                         return "No se tiene disponibles sillas en la ventana para clase economica.";
//                     }
//                     else if (ActualEconomicCorridorChair == EconomicCorridorChair) 
//                     {
//                         return "No se tiene disponible sillas en el corredor para clase economica.";
//                     }
//                     return "";
//                 default:
//                     return "No se tiene este tipo de preferencia.";
//             }
//         }
        
//     }
// }