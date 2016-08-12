using System;
namespace FoodSearch
{
	public class FoodManager
	{
		private static FoodManager _instance = null;
		public FoodData[] Foods;
		public static FoodManager Create()
		{
			if (_instance == null) 
				_instance = new FoodManager();
			return _instance;
		}
		internal FoodManager()
		{
			Foods = new FoodData[6] {
				new FoodData("1", "Chicken noodles", "Soup for the soul: Tina Li's chicken stock soup with pork meatballs and tofu.", "chinese_0.jpg", "1. Soak the rice noodles for 5 minutes in 90C hot water, and another 30 minutes in cold water. Then drain off the water.\r\n2. Tear the oyster mushroom, black fungus, and bok choy into small pieces.\r\n3. Slice the tofu and tomato.\r\n4. Now, to prepare the pork meatballs; mix all ingredients together, and knead the mix into small round balls. Then cook them in boiling water for 10 minutes.\r\n5. Place cooked pork meatballs, sliced tofu, tomato, black fungus, beancurd skin, bok choy, quail eggs, and beanshoot sprouts in a casserole dish.\r\n6. Boil the rice noodle and all the ingredients with chicken stock in the casserole for five minutes on a high flame.\r\n7. Serve with chopped spring onion on the top."),
				new FoodData("2", "Wonton noodles",  "Vibrant prawn and wonton noodle soup: substitute the prawn for chicken if you prefer.", "chinese_1.jpg", "1. To make the wonton mixture, mix the chopped prawn meat together with all the other ingredients except the wonton skins.\r\n2. Lay out a wonton skin and put 1 tbsp of prawn mixture into the centre. Brush 2 edges of the skin lightly with water and fold the skins in half at an angle to enclose the filling and seal the edges. Place the wonton aside and repeat with the remaining 15 wonton skins.\r\n3. To make the soup, heat the chicken stock in a pan over medium heat. When it comes to a simmer, add soy sauce, ginger and spring onions then reduce the heat to a very gentle simmer. Add a pinch of ground white pepper. Check the seasoning and if necessary adjust with a little more soy or sea salt.\r\n4. In a separate pot of simmering water, gently cook the wontons for about 3 minutes until just soft. Remove from the water and divide between 4 large bowls. Divide the noodles and bok choy between the 4 bowls and pour over the seasoned stock. Serve immediately."),
				new FoodData("3", "Teriyaki fish", "Delicious: Find out why teriyaki is traditionally a fish dish in Japan.", "japanese_0.jpg", "1.  To make the teriyaki glaze, mix the mirin, sake, sugar and soy sauce together and stir to dissolve the sugar.\r\n2. Dust the fish fillets with cornflour. Heat a frypan over medium heat until very hot and add the oil. Fry the spring onions until lightly browned and set aside.\r\n3.  Add the fish and fry for about four minutes (two minutes on each side) then the teriyaki glaze.\r\n4. Continue to cook for about two to three minutes, turning the fish through the glaze every minute or so until the glaze is thick, glossy and holding as a dark coating on the fish, and the fish is cooked through.\r\n5. Remove the fish from the pan to a plate with the spring onions, and pour over any remaining glaze to serve."),
				new FoodData("4", "Breakfast miso", "Warm and soothing, sip after sip: Breakfast miso.", "japanese_1.jpg", "1. Shave the pumpkin or carrot into strips with a vegetable peeler, and slice the snowpeas lengthwise into strips. Bring the water or stock to the boil, add the pumpkin, snowpeas, dashi powder, mirin and soy and simmer for five minutes.\r\n2. Cook the noodles in simmering, salted water for four minutes or until al dente, then drain and divide between four, warm, Asian soup bowls.\r\n3. In a small bowl, mix a ladleful of the soup with the miso then pour back into the soup, whisking well. Add the tofu and heat through, without boiling.\r\n4. Divide soup between warm bowls, place half an egg on top, scatter with torn nori, spring onion and sesame seeds and serve."),
				new FoodData("5", "Spanish chicken", "A simple braise suitable for a midweek dinner.", "spanish_0.jpg", "1.CUT BREAST PIECES in half. Take the legs and cut the drumstick from the thighs at the joints. Season chicken with salt.\r\n2.HEAT THE OIL in a deep, heavy-based saucepan that has a tight-fitting lid. Fry the garlic cloves (with skins on) over a medium heat until lightly golden, remove and set aside. Add the chicken in batches and fry until golden brown on all sides, about 5 minutes per batch. Pour off any excess fat rendered from the chicken. \r\n3.RETURN THE GARLIC to the saucepan along with the bay leaves, and pour in the sherry, shaking the pan to help the wine emulsify with the oil. Simmer for two minutes while turning the chicken in the sauce.\r\n4.ADD ½ CUP WATER, place on lid and simmer for four minutes. The leg pieces will take longer to cook, so remove the breast pieces once cooked and set aside. Continue to cook the remaining chicken until ready, adding more water to the sauce if needed. Add all the chicken and warm through. Check seasoning.\r\n5.SERVE with pilaf and seasonal greens. Finish of your feast with Neil Perry's Spanish quince and almond tart."),
				new FoodData("6", "Simply Spanish", "Spanish style chorizo, saffron and chickpea soup.", "spanish_1.jpg", "1.Drain the chickpeas, rinse and place in a saucepan of fresh water. Bring to the boil, then reduce heat to low and simmer for 45 minutes or until tender. Drain well.\r\n2.Meanwhile, heat oil in a saucepan over medium-high heat. Add chorizo and cook, stirring, for 2 minutes or until browned. Transfer to a bowl and set aside. To the same pan add the garlic, onion and saffron. Reduce heat and cook, stirring, until onions have softened.\r\n3.Add the sherry and deglaze the pan, scraping the base with a wooden spoon.\r\n4.Add the stock and potato and bring to the boil. Reduce heat to low and simmer, stirring occasionally, for about 15 minutes.\r\n5.Add the zucchini and cook until it has softened. Stir through the chickpeas, spinach and chorizo, and cook for a few minutes until just heated through. Season to taste and serve immediately.")


			};
		}
	}


	public class FoodData
	{
		public string FoodID { get; set; }
		public string FoodName { get; set; }
		public string FoodDescription { get; set;}
		public string FoodImage { get; set;}
		public string FoodRecipe { get; set; }

		public FoodData()
		{
		}

		public FoodData(string id, string title, string description, string image, string recipe)
		{
			FoodID = id;
			FoodName = title;
			FoodDescription = description;
			FoodImage = image;
			FoodRecipe = recipe;
		}
	}

}

