using system.IO;
string line;
string pathlyrics ="efullone$\lyricprompter\lyrics\damnation.rtf";
try
{streamreader sr = new streamreader (pathlyrics)
line = sr.readline();
while (line!=null)
{
//write the lie to console window
Console.WriteLine(line);
//Read the next line
line = sr.ReadLine();
}

//close the file
sr.Close();
Console.ReadLine();
}
catch(Exception e)
{
Console.WriteLine("Exception: " + e.Message);
}
   finally 
{
Console.WriteLine("Executing finally block.");
}