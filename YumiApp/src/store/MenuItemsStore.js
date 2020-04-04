import axios from 'axios'

const MenuItemsStore = {
    state: {
        menuItems: [{}],
    },
    getAllMenuItems(){
        let webAPIUrl = "https://localhost:5001/menuitems";
        axios.get( webAPIUrl )
            .then( result => {
                
                this.state.menuItems = result.data;
                console.log("STATE RUNNING");
                console.log(this.state.menuItems + "lol");
               
            } )
               
        return this.state.menuItems.map( menuItem => menuItem);

      

    },



    


}

export default MenuItemsStore;