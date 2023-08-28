using SteveSharp;
namespace RetoHardcore;

public static class SedDisplay
{
    static FileOrganizer FO = new FileOrganizer();
    static string[] FunctionLines = new string[]{};
    static void GetFunctionText(string path){
        FunctionLines = File.ReadAllLines(path);
    }
    public static void Create(){
        if(File.Exists("sed_display.mcfunction")){
            GetFunctionText("sed_display.mcfunction");
            File.Move("sed_display.mcfunction","./../sed_display.mcfunction");
        } else if(File.Exists("./../sed_display.mcfunction")){
            GetFunctionText("./../sed_display.mcfunction");
        } else if(File.Exists("./../../../../sed_display.mcfunction")){
            GetFunctionText("./../../../../sed_display.mcfunction");
            File.Copy("./../../../../sed_display.mcfunction", "./../sed_display.mcfunction");
        }
        Function f = new Function(FO.GetFunctionPath("reto:sed_display"));
        f.WriteAllCommands(FunctionLines);
    }
}