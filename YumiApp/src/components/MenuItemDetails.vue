<template>
    <div>

        <template v-if="Object.keys(menuItem).length === 0">
   
           <h1 class="display-4">FAEN</h1>

        </template>
        <template v-else>

        <v-card flat height="800">
            <v-row>
                <v-col>
                    <v-card-title class="display-2 font-weight-bold">{{menuItem.title}}</v-card-title>
                    <v-img :src="`https://localhost:5001/images/${menuItem.imgUrl}`" height="350px"></v-img>
                </v-col>

            </v-row>
            <v-row>
                <v-col cols="12" sm="4" lg="4">
                    <v-card-text>{{menuItem.category}}</v-card-text>
                    <v-card-subtitle>Allergens:</v-card-subtitle>
                    <v-card-text>{{menuItem.allergens}}</v-card-text>
                </v-col>
                <v-col cols="12" sm="8" lg="8">
                    <v-card-text>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Quibusdam dolore eligendi numquam optio, iste neque iusto debitis repellendus nisi quos?
                    </v-card-text>
                    <v-btn depressed rounded color="amber accent-3" class="ml-3">Order</v-btn>
                    </v-col>
            </v-row>
        </v-card>
        </template>

    </div>
</template>
<script>
export default {
    name: 'MenuItem',
    data(){
        return {
        menuItem: {}
        }
    },
    methods: {
        getItem(item) {
            const webAPIUrl = `https://localhost:5001/menuitems/${item}`;
            this.$http.get(webAPIUrl)
                .then( response => {
                    this.menuItem = response.data;
                    console.log(this.menuItem)
                });
        }
    },
    created() {
        this.getItem(this.$route.params.id)
        console.log(this.$route.params.id)
        }
    }
</script>

<style scoped>
.ovl {
    background-color: red;
    
}

.chip-bg {
    background-color: rgba(0,0,0,0.65);
}

.overlay-gradient {
height: 300px;
background: -moz-linear-gradient(bottom, rgba(0,0,0,0.65) 0%, rgba(0,0,0,0) 100%); /* FF3.6-15 */
background: -webkit-linear-gradient(bottom, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* Chrome10-25,Safari5.1-6 */
background: linear-gradient(to top, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* W3C, IE10+, FF16+, Chrome26+, Opera12+, Safari7+ */
}
</style>