const AllergensStore = {
    state: {
        allergens: [ "None", "Crab", "Fish", "Salmon", "Shellfish" ]
    },
    // Gir tilgang til å hente ut all data
    getAll(){
       return this.state.allergens.map( allergens => allergens );
    }
}

export default AllergensStore;