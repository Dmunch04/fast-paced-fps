﻿using UnityEngine;
using UnityEngine.UI;

using Steamworks;

public class AccountUI : MonoBehaviour
{

    // Takes in the username text
    public Text Username;

    // Crates a MenuStatus variable, called status
    private MenuStatus Status;

    void Awake ()
    {

        // Sets the status variable to an instance of menustatus
        Status = MenuStatus.Instance;
    }

    // Start Method :: Gets called in the start
    void Start ()
    {

        // Checks if the user is logged in
        if (SteamAPI.Init())
        {

            // Set the name string to the steam users name
            string name = SteamFriends.GetPersonaName();

            // If so, set the username text to the logged in username
            Username.text = name;

        }

        // If not
        else
        {

            // Then set the status text to the message
            Status.SetStatus("You're not logged in");

            // Why wouldn't you be logged in lmao?

        }

    }

    // ButtonLogout Method :: Gets called when clicking on the logout menu button
    public void ButtonLogout ()
    {

        // Checks if the user is logged in
        if (SteamAPI.Init())
        {

            // Logout

        }

        // If not
        else
        {

            // Then set the status text to the message
            Status.SetStatus("You're not logged in");

            // Why wouldn't you be logged in lmao?

        }

    }

}