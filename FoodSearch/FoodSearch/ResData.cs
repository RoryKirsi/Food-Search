using System;
namespace FoodSearch
{
	public class ResManager
	{
		private static ResManager _instance = null;
		public ResData[] Ress;
		public static ResManager Create()
		{
			if (_instance == null)
				_instance = new ResManager();
			return _instance;
		}
		internal ResManager()
		{
			Ress = new ResData[6] {
				new ResData("1", "Eureka 89", "Level 89, 7 Riverside Quay, Southbank, Melbourne", "restaurant_0.png", "Phone number\n03 9693 8889\nCuisines\nModern Australian\nCost \nA$250 for two people (approx.)\nCash and Cards accepted\nOpening hours\nToday  12 Noon to 4 AM\nSee more\nAddress\nLevel 89, 7 Riverside Quay, Southbank, Melbourne\nEureka 89 address, Eureka 89 location Get Directions\nHighlights\n\nFull Bar Available\nDegustation\nWifi\nVegan Options\nVegetarian Friendly\nGluten Free Options\nFeatured in Collections\nA View To Dine For\nSo Romance\nKnown For\nElegant dining with stunning views from Melbourne's tallest building.\n", "enviro_0.jpg"),
				new ResData("2", "McDonalds",  "318 Whitehorse Road, Balwyn, Melbourne, VIC", "restaurant_1.png", "Phone number\n03 9830 0200\nCuisines\nFast Food\nCost \nA$20 for two people (approx.)\nCash and Cards accepted\nOpening hours · Open now\nToday  24 Hours\nSee more\nAddress\n318 Whitehorse Road, Balwyn, Melbourne, VIC\nSee 179 more locations ›\nMcDonald's address, McDonald's location Get Directions\nHighlights\n\nBreakfast\nTakeaway Available\nWheelchair Accessible\nOutdoor Seating\nKid Friendly\nWifi\nDrive Thru", "enviro_1.jpg"),
				new ResData("3", "Chocolate Brew House", "103 Poath Road, Hughesdale & Murrumbeena, Melbourne, VIC", "restaurant_2.jpg", "Phone number\n03 9568 3226\nCuisines\nCafe\nCost \nA$50 for two people (approx.)\nCash and Cards accepted\nOpening hours\nToday  8 AM to 4 PM\nSee more\nAddress\n103 Poath Road, Hughesdale & Murrumbeena, Melbourne, VIC\nBrew address, Brew location Get Directions\nHighlights\n\nBreakfast\nTakeaway Available\nGluten Free Options\nOutdoor Seating\nKid Friendly\nVegetarian Friendly", "enviro_2.jpg"),
				new ResData("4", "Dinner by Heston Blumemthal", "Crown Melbourne, Level 3, 8 Whiteman Street, Southbank, Melbourne", "restaurant_3.jpg", "Phone number\n03 9292 5777\nCuisines\nEuropean\nCost \nA$300 for two people (approx.)\nCash and Cards accepted\nOpening hours\nToday  5:30 PM to 11 PM\nSee more\nAddress\nCrown Melbourne, Level 3, 8 Whiteman Street, Southbank, Melbourne\nMore in Crown Melbourne, Southbank (51)\nDinner by Heston Blumenthal address, Dinner by Heston Blumenthal location Get Directions\nHighlights\n\nFull Bar Available\nVegetarian Friendly\nFeatured in Collection\nSo Romance\nKnown For\nA unique dining experience that fuses ancient and modern, classic and contemporary", "enviro_3.jpeg"),
				new ResData("5", "Dainty SiChuan", "176 Toorak Road, South Yarra, Melbourne", "restaurant_4.png", "Phone number\n03 9078 1686\nCuisines\nChinese, Sichuan\nCost \nA$120 for two people (approx.)\nCash and Cards accepted\nOpening hours\nToday  11:30 AM to 3 PM, 5 PM to 9:30 PM\nSee more\nAddress\n176 Toorak Road, South Yarra, Melbourne\nSee 4 more locations ›\nDainty Sichuan address, Dainty Sichuan location Get Directions\nHighlights\n\nTakeaway Available\nWine and Beer\nVegetarian Friendly\nKnown For\nAuthentic Szechuan cuisine with tongue-numbing dishes", "enviro_4.jpg"),
				new ResData("6", "Laksa King", "6-12 Pin Oak Crescent, Flemington, Melbourne, VIC", "restaurant_5.jpg", "Phone number\n03 9372 6383\nCuisines\nMalaysian, Chinese\nCost \nA$70 for two people (approx.)\nCash only\nOpening hours\nToday  11:30 AM to 3 PM, 5 PM to 10 PM\nSee more\nAddress\n6-12 Pin Oak Crescent, Flemington, Melbourne, VIC\nSee 1 more location ›\nLaksa King address, Laksa King location Get Directions\nHighlights\n\nTakeaway Available\nWheelchair Accessible\nFull Bar Available\nBYO\nKid Friendly\nVegetarian Friendly\nBYOW\nFeatured in Collection\nThe Malay Way\nKnown For\nWide range of laksas, with a bustling atmosphere and industrial style", "enviro_5.jpg")


			};
		}
	}


	public class ResData
	{
		public string ResID { get; set; }
		public string ResName { get; set; }
		public string ResDescription { get; set; }
		public string ResImage { get; set; }
		public string ResOverView { get; set;}
		public string ResEnviro { get; set; }

		public ResData()
		{
		}

		public ResData(string id, string title, string description, string image, string overview, string enviroment)
		{
			ResID = id;
			ResName = title;
			ResDescription = description;
			ResImage = image;
			ResOverView = overview;
			ResEnviro = enviroment;
		}
	}
}

