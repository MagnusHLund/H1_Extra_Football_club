using H1_Extra_Football_club.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Extra_Football_club.Controller
{
	/// <summary>
	/// This class is the controller for this program.
	/// </summary>
	internal class MainController
	{
		Database database = new Database();
		View.View view = new View.View();


		/// <summary>
		/// This method is the entry point for the class. It gets called from Program.Main().
		/// It contains an infinite loop, so the program never ends.
		/// First it displays the menu screen, followed by a switch statement that uses the byte value from UserOptions().
		/// It checks which method it should call, based on the byte value.
		/// Once the switch statement is over, it clears the console view.
		/// </summary>
		internal void Start()
		{
			while (true)
			{
				MainMenu();

				switch (UserOptions())
				{
					case 1:
						ShowAll();
						break;
					case 2:
						AddMember();
						break;
					case 3:
						RemoveMember();
						break;
				}

				view.Clear();
			}
		}

		/// <summary>
		/// This method outputs the main menu.
		/// First a string array is created, which contains each line of the menu, in different strings.
		/// A for loop then goes through each line, changes the color between white and dark grey and outputs the appropriate line, based on the value of 'i'.
		/// </summary>
		private void MainMenu()
		{
			string[] menu = { "Football Admin site", "1.\tSee all members", "2.\tAdd member", "3.\tRemove member", };

			for (byte i = 0; i < menu.Length; i++)
			{
				view.Color(i);
				view.Message(menu[i]);
			}
		}

		/// <summary>
		/// This method returns user input, based on if they user wants to see all members, add a member or delete a member.
		/// If any parsing error occurs, then it returns 0.
		/// If the byte value that the user wrote is invalid due to the switch statement in Start() not using the value,
		/// then the program just repeats and the user gets a chance to write again, instantly.
		/// </summary>
		/// <returns></returns>
		private byte UserOptions()
		{
			try
			{
				return byte.Parse(view.ReadLine());
			}
			catch 
			{
				return 0;
			}
		}
		
		/// <summary>
		/// This method goes through each member in the database and outputs their name and phone number, along with their MemberNumber.
		/// The MemberNumber is used for deleting the members.
		/// Once all the members are dispalyed, the user has to press enter to do their next prompt.
		/// </summary>
		private void ShowAll()
		{
			for (int i = 0; i < database.members.Count; i++)
			{
				Member member = database.members[i];
				view.Message($"MemberNumber: {i}, Name: {member.Name}, Phone: {member.Phone}");
			}

			view.Message("Press enter to continue");
			view.ReadLine();
		}

		/// <summary>
		/// This method adds members to the database.
		/// The user has to write the members name and phone number, then the member gets put in the database.
		/// </summary>
		private void AddMember()
		{
			Member member = new Member();

			view.Message("What is the members name?");
			member.Name = view.ReadLine();

			view.Message("What is the members phone number?");
			member.Phone = view.ReadLine();

			database.members.Add(member);
		}

		/// <summary>
		/// First the user is prompted to write the id of the user they want to delete.
		/// Exception handling is then used, in case the written id cant be parsed or if the member does not exist in the database.
		/// If no errors occur, the member with the matching id gets deleted from the database.
		/// </summary>
		private void RemoveMember()
		{
			view.Message("Write the ID of the member that you want to delete.");

			try
			{
				int id = int.Parse(view.ReadLine());

				database.members.RemoveAt(id);
			}
			catch (ArgumentOutOfRangeException)
			{
				view.Message("Member does not exist!\nPress enter to continue!");
				view.ReadLine();
			}
			catch (FormatException)
			{
				view.Message("Invalid ID, write numbers only!\nPress enter to continue!");
				view.ReadLine();
			}
		}
	}
}
