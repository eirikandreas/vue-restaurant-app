<template>
    <div class="d-flex align-center">
        <span class="caption mr-2">({{ menuItem.rating }})</span>
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
        itemId: { type: Number, required: true, default: 0}
    },
    data() {
        return {
            menuItem: {},
        }
    },
    methods: {
        /*
        Henter rett fra APIet basert på den verdien som er sendt inn
        via props og legger resultatet inn i menuItem objektet
        */
        getRating() {
            let webAPIUrl = `https://localhost:5001/user/menuitems/${this.itemId}`;
            this.$http.get(webAPIUrl)
                .then(result => {
                    this.menuItem = result.data;
                })
        },
        //Skriver menuItem objektet tilbake til APIet
        setRating() {
            let webAPIUrl = "https://localhost:5001/user/menuitems";
            this.$http.put(webAPIUrl, this.menuItem)
        }
    },
    created() {
        this.getRating()
    }
}
</script>