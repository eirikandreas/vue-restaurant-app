<template>
    <div class="d-flex align-center">
        <span class="grey--text text--lighten-2 caption mr-2">({{ menuItem.rating }})</span>
            <v-rating 
            v-model="menuItem.rating" 
            background-color="white" 
            color="amber accent-3" 
            dense 
            hover 
            size="18" 
            half-increments 
            @input="setRating()"
            ></v-rating>
    </div>
</template>
<script>
export default {
    name: 'MenuItemRating',
    props: {
        itemId: { type: Number, default: 0}
    },
    data() {
        return {
            menuItem: {},
        }
    },
    methods: {
        getRating() {
            let webAPIUrl = `https://localhost:5001/menuitems/${this.itemId}`;
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