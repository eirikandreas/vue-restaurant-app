const CategoriesStore = {
    state: {
        categories: [
            { id: 1, name: "Appetizers", desc: "Lorem ipsum", imgSrc: "1.jpg", blackIcon: "appetizer.png"},
            { id: 3, name: "Maki", desc: "Lorem ipsum", imgSrc: "2.jpg", blackIcon: "maki.png" },
            { id: 4, name: "Nigiri", desc: "Lorem ipsum", imgSrc: "3.jpg", blackIcon: "nigiri.png" },
            { id: 5, name: "Sashimi", desc: "Lorem ipsum", imgSrc: "4.jpg", blackIcon: "sashimi.png" },
            { id: 7, name: "Desserts", desc: "Lorem ipsum", imgSrc: "1.jpg", blackIcon: "dessert.png" },
            { id: 8, name: "Drinks", desc: "Lorem ipsum", imgSrc: "2.jpg", blackIcon: "drink.png" },
        ]
    },
    get(){
       return this.state.categories.map( category => category );
    },
    getCategory(id){
        return this.state.categories.find (category => category.id == id);
    }

}

export default CategoriesStore;