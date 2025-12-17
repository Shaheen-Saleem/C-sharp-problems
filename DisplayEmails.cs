/*
Your challenge is to create a method that displays the correct email address for both internal and external employees. 
You're given lists of internal and external employee names. An employee's email address consists of their username and company domain name.

The username format is the first two characters of the employee first name, followed by their last name. 
For example, an employee named "Robert Bavin" would have the username "robavin". The domain for internal employees is "contoso.com".

Required Output:
robavin@contoso.com
sibright@contoso.com
kisinclair@contoso.com
aakamath@contoso.com
sadelucchi@contoso.com
siali@contoso.com
viashton@hayworth.com
codysart@hayworth.com
shlawrence@hayworth.com
davaldes@hayworth.com
*/

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string internalDomain = "contoso.com";
string externalDomain = "hayworth.com";

void DisplayInternalEmailAddresses(string[,] internalNames, string internalDomain)
{
    string[] internalEmails = new string[internalNames.GetLength(0)];
    for (int i = 0; i < internalNames.GetLength(0); i++)
    {
        string firstName = internalNames[i, 0];
        string lastName = internalNames[i, 1];
        string emailInternal = firstName.ToLower().Substring(0, 2) + lastName.ToLower() + "@" + internalDomain;
        internalEmails[i] = emailInternal;
    }
    foreach (var internalEmail in internalEmails)
    {
        Console.WriteLine(internalEmail);
    }
}

void DisplayExternalEmailAddresses(string[,] externalNames, string externalDomain)
{
    string[] externalEmails = new string[externalNames.GetLength(0)];
    for(int i = 0; i < externalNames.GetLength(0); i++)
    {
        string firstName = externalNames[i, 0];
        string lastName = externalNames[i, 1];
        string emailExternal = firstName.ToLower().Substring(0, 2) + lastName.ToLower() + "@" + externalDomain;
        externalEmails[i] = emailExternal;
    }
    foreach (var externalEmail in externalEmails)
    {
        Console.WriteLine(externalEmail);
    }
}

DisplayInternalEmailAddresses(corporate, internalDomain);
DisplayExternalEmailAddresses(external, externalDomain);
