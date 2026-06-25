string permission = "Admin|Manager";
int level = 55;

Console.WriteLine($"{( permission.Contains("Admin")? level > 55? "Welcome, Super Admin user.": "Welcome, Admin user." 
:  "Welcome LOSER")}");