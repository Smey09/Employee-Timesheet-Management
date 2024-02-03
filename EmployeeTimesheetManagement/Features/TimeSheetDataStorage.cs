using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EmployeeTimesheetManagement.Features;

public class TimeSheetDataStorage {
    public static void SaveTimeSheetToStorage(Timesheet attenList) {
        var jsonString = JsonSerializer.Serialize(attenList);
        File.WriteAllText("Timesheet.json", jsonString);
    }

    public static Timesheet LoadTimeSheetFromStorage() {
        using FileStream stream = File.Open("Timesheet.json", FileMode.OpenOrCreate);
        if (stream.Length > 0) {
            var loadList = JsonSerializer.Deserialize<Timesheet>(stream);
            return loadList!;
        }
        return new Timesheet();
    }
}
