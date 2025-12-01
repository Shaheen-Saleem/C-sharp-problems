/*
Here are the conditions that your second coding project must implement:

    Your solution must include either a do-while or while iteration.

    Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

    Inside the iteration block:
        Your solution must use a Console.ReadLine() statement to obtain input from the user.
        Your solution must ensure that the value entered matches one of the three role options.
        Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
        Your solution should use the ToLower() method on the input value to ignore case.
        If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.

    Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

*/

string? role;
Console.WriteLine("Specify your role (Adminstrator, Manager, or User): ");
string role1 = "administrator";
string role2 = "manager";
string role3 = "user";
bool validRole = false;

do
{
    role = Console.ReadLine();
    if (role != null)
    {
        string roleWithNoWhiteSpaces = role.Trim();
        string roleInLower = roleWithNoWhiteSpaces.ToLower();
        if ((roleInLower != role1) && (roleInLower != role2) && (roleInLower != role3))
        {
            Console.WriteLine($"The role name that you entered, \"{role}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            validRole = false;
        }
        else
        {
            validRole = true;
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid role: ");
    }
} while (!validRole);

Console.WriteLine($"Your input value ({role}) has been accepted!");
