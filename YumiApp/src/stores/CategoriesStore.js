const CategoriesStore = {
    state: {
        categories: [
            { id: 1, name: "All", imgSrc: "categories/1.jpg", blackIcon: "menu.png", whiteIcon: "menu.png" },
            { id: 1, name: "Appetizers", imgSrc: "categories/1.jpg", blackIcon: "appetizer.png", whiteIcon: "appetizer-w.png" },
            { id: 3, name: "Maki", imgSrc: "categories/2.jpg", blackIcon: "maki.png", whiteIcon: "maki-w.png" },
            { id: 4, name: "Nigiri", imgSrc: "categories/3.jpg", blackIcon: "nigiri.png", whiteIcon: "nigiri-w.png" },
            { id: 5, name: "Sashimi", imgSrc: "categories/4.jpg", blackIcon: "sashimi.png", whiteIcon: "sashimi-w.png" },
            { id: 7, name: "Sushi", imgSrc: "categories1.jpg", blackIcon: "food.png", whiteIcon: "food.png" },
        ]
    },
    // Gir tilgang til å hente ut all data
    getAll(){
       return this.state.categories.map( category => category );
    },
    // Gir tilgang til å hente ut data basert på id
    getId(id){
        return this.state.categories.find( category => category.id == id );
    },
    // Gir tilgang til å hente ut data basert på navn
    getName(){
        return this.state.categories.map( category => category.name );
    }
}

export default CategoriesStore;