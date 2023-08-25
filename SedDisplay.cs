using System.IO;
using SteveSharp;
namespace RetoHardcore;

public class SedDisplay
{
    FileOrganizer FO = new FileOrganizer();
    string[] FunctionLines = new string[]{};
    void GetFunctionText(string path){
        FunctionLines = File.ReadAllLines(path);
    }
    public void Create(){
        if(File.Exists("sed_display.mcfunction")){
            GetFunctionText("sed_display.mcfunction");
        } else if(File.Exists("./../sed_display.mcfunction")){
            GetFunctionText("./../sed_display.mcfunction");
            File.Copy("./../sed_display.mcfunction", "sed_display.mcfunction");
        } else if(File.Exists("./../../../../sed_display.mcfunction")){
            GetFunctionText("./../../../../sed_display.mcfunction");
            File.Copy("./../../../../sed_display.mcfunction", "sed_display.mcfunction");
        }
        Function f = new Function(FO.GetFunctionPath("reto:sed_display"));
        f.WriteAllCommands(FunctionLines);
    }
}