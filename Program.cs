/*
 * Project: Secure User Management & Authentication System
 * Author: Tina Ying Wang
 * Date: Feb 2026
 * Description: A C# implementation of a secure login system featuring 
 * dictionary-based data storage and account lockout protection.
 */

string username;
bool isUsername = false;
bool isPassword = false;
bool isExist = false;
string chkNextUN = "";
string chkNextPW = "";
string chkNextNUN = "";
string chkNextNU = "";
string newUsername = "";
string newPassword = "";
int loginCount = 0;
int maxCount = 3;

// ignoring case only applies to key of dictionary; it ensures that users can be identified even if they enter their username with different casing
// Using Dictionary for O(1) lookup performance and case-insensitive key comparison
Dictionary<string, string> users = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
users.Add("Nirmal", "nc@HOIT");
users.Add("Michael", "mike$123");
users.Add("John", "123#456");
users.Add("Kevin", "Kev@123");
users.Add("Sandra", "San$999");

Console.WriteLine("Current Users:");
int count = 0;
foreach (KeyValuePair<string, string> kvp in users)
{
    count++;
    Console.WriteLine($"\n{count}.{kvp.Key}");
}

// add new user
Console.WriteLine("\nAdd a New User");
Console.WriteLine("===================");
Console.WriteLine("\nTo be able to add a new user, you have to be a Valid user in the system.");
Console.WriteLine("\nPlease log in first.");


//verify the current username
do
{
    Console.Write("\nPlease enter your username: ");

    // Normalize user input to ensure consistency during validation
    username = Console.ReadLine().Trim().ToLower();

    // Verify if the entered username exists in the system records
    foreach (KeyValuePair<string, string> user in users)
    {
        if (username == user.Key.Trim().ToLower())
        {
            isUsername = true;
            username = user.Key;// assign the correct case of username to variable username, allow users[username] to return value
            Console.WriteLine("\nYour username is verified.");
            break;
        }

    }

    // If the username user entered doesn't exist, ask them if they want to try again
    if (!isUsername)
    {
        Console.WriteLine("\nThe username you entered doesn't exist.");
        do
        {
            Console.Write("\nDo you want to try again? (Y/N) ");
            chkNextUN = Console.ReadLine().Trim().ToLower();
            if (chkNextUN != "y" && chkNextUN != "n")
            {
                Console.WriteLine("\nInvalid input.Please try again.");
                continue;
            }
            else
            {
                if (chkNextUN == "n")
                {
                    Console.WriteLine("\nYou chose not to continue. Thank you.");
                    return;
                }
                else
                {
                    break;
                }

            }
        } while (chkNextUN != "y" && chkNextUN != "n");


    }


} while (!isUsername);

// After verifying the username, verify the password
do
{
    Console.Write("\nPlease enter your password: ");
    string password = Console.ReadLine();

    loginCount++;


    if (isUsername && password == users[username])
    {
        isPassword = true;
        Console.WriteLine("\nYour password is verified.");
    }

    if (!isPassword)
    {
        Console.WriteLine($"\nThe password you entered isn't correct (attempt {loginCount} out of {maxCount} attempts).");

        // Security Feature: Prevent brute-force attacks by limiting login attempts
        if (loginCount == maxCount)
        {
            Console.WriteLine("\nMaximum attempts reached. Account has been locked. Please contact admin.");
            return;
        }

        do
        {
            Console.Write("\nDo you want to try again? (Y/N) ");
            chkNextPW = Console.ReadLine().Trim().ToLower();
            if (chkNextPW != "y" && chkNextPW != "n")
            {
                Console.WriteLine("\nInvalid input.Please try again.");
                continue;
            }
            else
            {
                if (chkNextPW == "n")
                {
                    Console.WriteLine("\nYou chose not to continue. Thank you.");
                    return;
                }
                else
                {
                    break;
                }

            }
        } while (chkNextPW != "y" && chkNextPW != "n");

    }




} while (!isPassword);



if (isUsername && isPassword)
{
    Console.WriteLine("\nLogin Successful!");
}

// allow user to add another new username
do
{
    // ask the user to enter a new username
    do
    {
        Console.Write("\nPlease enter a new username to be added: ");
        newUsername = Console.ReadLine();
        Console.WriteLine();

        isExist = false;
        foreach (KeyValuePair<string, string> user in users)
        {

            // Ensure data integrity by checking if the new username already exists before adding
            if (newUsername.Trim().ToLower() == user.Key.Trim().ToLower())
            {
                isExist = true;
                Console.WriteLine($"Username {newUsername} already exists.");
                do
                {
                    Console.Write("\nDo you want to try again? (Y/N) ");
                    chkNextNUN = Console.ReadLine().Trim().ToLower();
                    if (chkNextNUN != "y" && chkNextNUN != "n")
                    {
                        Console.WriteLine("\nInvalid input.Please try again.");
                        continue;
                    }
                    else
                    {
                        if (chkNextNUN == "n")
                        {
                            Console.WriteLine("\nYou chose not to continue. Thank you.");
                            return;
                        }
                        else
                        {
                            break;
                        }

                    }
                } while (chkNextNUN != "y" && chkNextNUN != "n");

                if (chkNextNUN == "y")
                {
                    continue;
                }
                else
                {
                    return;
                }

            }

        }

        if (!isExist)
        {
            break;
        }

    } while (isExist);


    // ask the user to enter a password for this new username
    Console.Write("Please enter your password for this new username: ");
    newPassword = Console.ReadLine();

    users.Add(newUsername, newPassword);

    Console.WriteLine("\nYou have successfully added a new user.");

    Console.WriteLine("\nPlease see the modified users list below:");
    Console.WriteLine("===========================================");

    int i = 0;
    foreach (KeyValuePair<string, string> user in users)
    {
        i++;
        Console.WriteLine($"\n{i}.{user.Key}");
    }


    do
    {
        Console.Write("\nDo you want to add another user? (Y/N) ");
        chkNextNU = Console.ReadLine().Trim().ToLower();
        if (chkNextNU != "y" && chkNextNU != "n")
        {
            Console.WriteLine("\nInvalid input.Please try again.");
            continue;
        }
        else
        {
            if (chkNextNU == "n")
            {
                Console.WriteLine("\nYou chose not to continue. Thank you.");
                return;
            }
            else
            {
                Console.WriteLine("\nYou chose to continue.");
                break;
            }

        }
    } while (chkNextNU != "y" && chkNextNU != "n");


} while (chkNextNU == "y");