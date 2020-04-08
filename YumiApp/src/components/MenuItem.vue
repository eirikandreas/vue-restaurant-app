<template>
    <div>
        <v-hover v-slot:default="{ hover }">
            <v-card flat class="white--text">
                <v-img :src="`https:/localhost:5001/images/${image}`" height="300px">
                    <div class="overlay-gradient d-flex flex-column justify-end">
                        <div class="d-flex flex-row justify-space-between mb-3">
                            <div class="d-flex flex-column">
                                <v-card-title class="headline">{{title}}</v-card-title>
                                <v-card-subtitle class="white--text">{{category}}</v-card-subtitle>
                                <v-card-text>
                                    <div class="d-flex align-center">
                                        <span class="grey--text text--lighten-2 caption mr-2">({{ menuItem.rating }})</span>
                                        <v-rating 
                                        v-model="menuItem.rating" 
                                        background-color="white" 
                                        color="yellow accent-3" 
                                        dense 
                                        hover 
                                        size="18" 
                                        half-increments 
                                        @input="setRating()"
                                        ></v-rating>
                                    </div>
                                </v-card-text>
                            </div>
                            <div class="d-flex align-center">
                                <v-card-text>
                                    <v-chip style="backgroundColor:rgba(255,255,255,0.4)" class="font-weight-bold white--text">${{price}}</v-chip>
                                </v-card-text>
                            </div>
                        </div>
                        <v-expand-transition>
                            <div v-if="hover" class="d-flex transition-fast-in-slow-out">
                                <v-card-text>
                                    <v-btn rounded depressed color="amber accent-3 mr-3" :to="`/menu/${category.toLowerCase()}/${id}`">View</v-btn>
                                    <v-btn rounded depressed color="amber accent-3">Order</v-btn>
                                </v-card-text>
                            </div>
                        </v-expand-transition>
                    </div>
                </v-img>
            </v-card>
        </v-hover>
    
    </div>
</template>

<script>
export default {
    props: {
        id: { type: Number, default: 0 },
        title: { type: String, default: "Not set" },
        category: { type: String, default: "Not set" },
        price: { type: Number, default: 0 },
        rating: { type: Number, default: null },
        image: { type: String, default: "default.jpg" },
        btnRoute: { type: String, default: "default.jpg" },
    },
    name: 'MenuItem',
    data() {
        return {
            ratingId: null,
            menuItem: {}
        }
    },
    methods: {
        getRating() {
            let webAPIUrl = `https://localhost:5001/menuitems/${this.id}`;
            this.$http.get(webAPIUrl)
                .then(result => {
                    this.menuItem = result.data;
                })
        },
        setRating() {
            let webAPIUrl = "https://localhost:5001/menuitems";
            this.$http.put(webAPIUrl, this.menuItem)
            console.log(this.menuItem)

        }
    },
    created() {
        this.getRating()
    }
}
</script>

<style scoped>
.ovl {
    background-color: red;
}

.chip-bg {
    background-color: rgba(0, 0, 0, 0.65);
}

.overlay-gradient {
    height: 300px;
    background: -moz-linear-gradient(bottom, rgba(0, 0, 0, 0.65) 0%, rgba(0, 0, 0, 0) 100%);
    /* FF3.6-15 */
    background: -webkit-linear-gradient(bottom, rgba(0, 0, 0, 0.65) 0%, rgba(0, 0, 0, 0) 100%);
    /* Chrome10-25,Safari5.1-6 */
    background: linear-gradient(to top, rgba(0, 0, 0, 0.65) 0%, rgba(0, 0, 0, 0) 100%);
    /* W3C, IE10+, FF16+, Chrome26+, Opera12+, Safari7+ */
}
</style>