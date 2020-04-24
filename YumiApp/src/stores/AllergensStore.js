const AllergensStore = {
    state: {
        allergens: [ "Crab", "Fish", "Salmon", "Shellfish" ]
    },
    getAll(){
       return this.state.allergens.map( allergens => allergens );
    }
}

export default AllergensStore;