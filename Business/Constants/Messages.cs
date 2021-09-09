using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MemberAdded = "Üye  Eklendi";
        public static string MemberUpdated = "Üye  Güncellendi";
        public static string CheckIfMemberExists = "Aynı üye eklenemez";
        public static string CheckMemberGymTime = "Aynı saatte 15 üye salonda bulunabilir";

        public static string EmployeeAdded = "Personel Eklendi";
        public static string EmployeeUpdated = "Personel Güncellendi";
        public static string CheckIfEmployeeExists = "Aynı personel eklenemez";
        public static string EmployeeDeleted = "Personel Silindi";
        public static string CheckWorkingHour = "Bu çalışma saatinden en fazla 20 personel bulunabilir";

        public static string CheckIfWomanCount="Bu departmanda maksimum 5 kadın çalışabilir";
        public static string CheckIfManCount="Bu departmanda maksimum 5 erkek çalışabilir";

        public static string DepartmentAdded = "Departman Eklendi";
        public static string DepartmentUpdated = "Departman Güncellendi";
        public static string DepartmentNameExist="Aynı departman eklenemez";
        public static string DepartmentCount="Spor salonunda 15den fazla departman bulunamaz";
        
    }
}
