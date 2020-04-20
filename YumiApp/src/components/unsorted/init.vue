<template>
    <div>

        <!--

        { Id = 1, Title = "Miso Soup", Description = "Miso soup is a nutritious Japanese soup containing miso and dashi.", Ingredients= "Water, Miso, Tofu, Onion", Allergens = "Soy, Wheat, Sesame Seeds", Price = "55", Category = "Appetizer", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/85247_1._Miso_suppe_1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 2, Title = "Spring Rolls", Description = "Pork and vegetables are rolled in dough paper deep-fried w / sweet chili", Ingredients= "Garlic, Pork, Soy Sauce, Carrot", Allergens = "Eggs, Soy, Wheat, Shellfish", Price = "75", Category = "Appetizer", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/18842_V_rruller__2_stk.__1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 3, Title = "Tempura Fried Shrimp", Description = "4 scampi served with sweet chili sauce", Ingredients= "Shrimp, Cornstarch, Egg whites, Oil", Allergens = "Wheat, Shellfish", Price = "95", Category = "Appetizer", ImgUrl = "https://jakosushi.no/wp-content/uploads/2019/01/nr.-45.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 4, Title = "Prawn Crackers", Description = "Shrimp dough of fresh shrimp, tapiocamel and eggs. Steam, dry and fry in vegetable oil. Is traditionally eaten for dinner, but is also excellent for snacks.", Ingredients= "Prawn, Tapioca Starch, Baking Powder, Oil", Allergens = “Shellfish", Price = "25", Category = "Appetizer", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/89570_Rekechips_1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},


Vegetarian

        { Id = 5, Title = "Spicy Tofu Maki", Description = "Fried tofu and kimchi.", Ingredients= "Fried tofu, Kimchi, Rice", Allergens = “Sesame Seeds, Soy", Price = "82", Category = "Vegetarian, Maki", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/91546_56._Spicy_tofu_maki__8_biter____SE__SO___1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 6, Title = "Tofu Maki", Description = "Fried tofu with avocado and chilimajones.", Ingredients= "Fried tofu, Avocado, Chilli Mayonnaise, Rice", Allergens = “Sesame Seeds, Soy, Eggs", Price = "82", Category = "Vegetarian, Maki", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/91558_57._Tofu_maki__8_biter____SE__SO___1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},


Sushi Menu 

        { Id = 7, Title = "Small Sushi", Description = "3 salmon, 1 tuna, 4 salmon roe with spring onion.", Ingredients= "Rice, Salmon, Tuna, Scallions", Allergens = “Sesame Seeds, Fish", Price = "114", Category = "Sushi Menu", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/85359_3._Liten_sushi__8_biter__4_nigiri___4_maki__1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 8, Title = "Medium Sushi", Description = "5 salmon, 1 halibut, 1 tuna, 1 scampi, 4 salmon roe with spring onion.", Ingredients= "Rice, Salmon, Tuna, Halibut, Scallions", Allergens = “Sesame Seeds, Fish", Price = "155", Category = "Sushi Menu", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/85399_4._Medium_sushi__12_biter__8_nigiri___4_maki_1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 9, Title = "Large Sushi", Description = "5 salmon, 1 halibut, 1 tuna, 1 scampi, 8 salmon roe with spring onion.", Ingredients= "Rice, Salmon, Tuna, Halibut, Scallions", Allergens = “Sesame Seeds, Fish", Price = "185", Category = "Sushi Menu", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/85420_5._Stor_sushi__16_biter__8_nigiri___8_laks_m_1-edit.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},


Maki
        { Id = 10, Title = "Salmon Maki", Description = "Salmon with avocado or spring onion.", Ingredients= "Rice, Salmon, Avocado, Scallions", Allergens = “Sesame Seeds, Fish", Price = "85", Category = "Maki, Vegetarian", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/85602_9._Laks_maki_1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 11, Title = "Spicy Tuna Maki", Description = "Tuna with chilli mix.", Ingredients= "Rice, Tuna, Chilli", Allergens = “Sesame Seeds, Fish", Price = "95", Category = "Maki", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/85638_10._Spicy_tuna_maki_1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 12, Title = "California Maki", Description = "Crabstick with avocado and chilimajones.", Ingredients= "Rice, Prawn, Avocado, Chilli Mayonnaise", Allergens = “Sesame Seeds, Fish, Egg", Price = "85", Category = "Maki", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/85670_11._California_maki_1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 13, Title = "Tempura Maki", Description = "Fried scampi with avocado and chilimajones.",Ingredients= "Rice, Prawn, Avocado, Chilli Mayonnaise", Allergens = “Sesame Seeds, Fish, Egg, Wheat", Price = "95", Category = "Maki", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/85727_12._Tempura_maki_1-1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},

Sashimi

        { Id = 14, Title = "Small Sashimi", Description = "4 salmon, 2 tuna, 1 halibut and 3 scallops.", Ingredients= "Salmon, Tuna, Scallop", Allergens = “Fish, Shellfish, Sesame Seeds, Molluscs", Price = "135", Category = "Sashimi", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/89459_18._Liten_sashimi-meny__10_skiver__1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 15, Title = "Medium Sashimi", Description = "6 salmon, 2 tuna, 2 halibut, 4 scallops and 1 scampi.", Ingredients= "Salmon, Tuna, Scallop, Halibut", Allergens = “Fish, Shellfish, Sesame Seeds, Molluscs ", Price = "175", Category = "Sashimi", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/89459_18._Liten_sashimi-meny__10_skiver__1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 16, Title = "Large Sashimi", Description = "10 salmon, 5 tuna, 3 halibut, 4 scallops and 3 scampi.", Ingredients= "Salmon, Tuna, Scallop, Halibut", Allergens = “Fish, Shellfish, Sesame Seeds, Molluscs ", Price = "275", Category = "Sashimi", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/89459_18._Liten_sashimi-meny__10_skiver__1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},

Nigiri


        { Id = 17, Title = "Salmon", Description = "Optional nigiri sushi (2 pieces).", Ingredients= "Salmon, Rice", Allergens = “Fish", Price = "42", Category = "Nigiri", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/86251_21._Laks_1-1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 18, Title = "Tuna", Description = "Optional nigiri sushi (2 pieces).", Ingredients= "Tuna, Rice", Allergens = “Fish", Price = "46", Category = "Nigiri", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/86275_22._Tunfisk_1-1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 19, Title = "Scallop", Description = "Optional nigiri sushi (2 pieces).", Ingredients= "Scallop, Rice", Allergens = “Molluscs", Price = "46", Category = "Nigiri", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/86448_26._Kamskjell_1-1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},


Warm Dishes

        { Id = 20, Title = "Panang Chicken", Description = "Chicken with fresh vegetables, panang curry and coconut milk.", Ingredients= "Coconut Milk, Vegetables, Chicken, Panang Curry", Allergens = “Peanuts", Price = "149", Category = "Warm Dishes", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/86567_28._Panaeng_kylling_1-1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 21, Title = "Red Curry Steak", Description = "Beef with fresh vegetables in red curry and coconut milk.", Ingredients= "Coconut Milk, Vegetables, Steak, Red Curry", Allergens = “Peanuts", Price = "159", Category = "Warm Dishes", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/86701_31._R_d_curry_biff_1-1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 22, Title = "Beef Chopsuey", Description = "Steak with fresh vegetables in garlic oyster sauce.", Ingredients= "Beef, Vegetables, Garlic Sauce", Allergens = “Soy, Wheat", Price = "159", Category = "Warm Dishes", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/86797_34._Biff_chopsuey_1-1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 23, Title = "Chicken Chopsuey", Description = "Chicken with fresh vegetables in garlic oyster sauce.", Ingredients= "Chicken, Vegetables, Garlic Sauce", Allergens = “Soy, Wheat", Price = "149", Category = "Warm Dishes", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/86824_35._Kylling_chopsuey_1-1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},

Extra

        { Id = 24, Title = "Chilli Mayonnaise", Description = "Extra for your dish", Ingredients= "Egg, Chilli", Allergens = “Egg", Price = "15", Category = "Extra", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/89632_Ekstra_Chilimajones_1-1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},
        { Id = 25, Title = "Ginger", Description = "Extra for your dish", Ingredients= "Ginger", Allergens = "", Price = "15", Category = "Extra", ImgUrl = "https://jakosushi.no/wp-content/uploads/2018/04/89671_Ekstra_Ingef_r_1-1.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020" IsFeatured = "true"},













-->





    </div>
</template>
<script>
export default {
    name: 'init',
    data() {
        return {
            menuItems: 


        { Title:"Salmon Maki"},
        //{ Id = 11, Title = "Spicy Tuna Maki", Description = "Tuna with chilli mix.", Ingredients= "Rice, Tuna, Chilli", Allergens = "Sesame Seeds, Fish", Price = 85, Category = "Maki", ImgUrl="default.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020", IsFeatured = "true"},
        //{ Id = 12, Title = "California Maki", Description = "Crabstick with avocado and chilimajones.", Ingredients= "Rice, Prawn, Avocado, Chilli Mayonnaise", Allergens = "Sesame Seeds, Fish, Egg", Price = 85, Category = "Maki", ImgUrl="default.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020", IsFeatured = "true"},
        //{ Id = 13, Title = "Tempura Maki", Description = "Fried scampi with avocado and chilimajones.",Ingredients= "Rice, Prawn, Avocado, Chilli Mayonnaise", Allergens = "Sesame Seeds, Fish, Egg, Wheat", Price = 85, Category = "Maki", ImgUrl="default.jpg", Rating = "0", TimesOrdered = "0", DateAdded = "1/2/2020", IsFeatured = "true"},




        }
    },
    created() {

                const webAPIUrl = "https://localhost:5001/menuitems";
                this.$http.post(webAPIUrl, this.menuItems)
                    .then(response => {
                        console.log(response);
                        console.log("Save data to DB");
                    })

    }
}
</script>

