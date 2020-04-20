<template>
    <div>
        <section class="search">
            <v-sheet tile color="red">
        <v-container>
            
        <v-text-field outlined rounded clearable hide-details dark color="amber accent-3" append-icon="mdi-magnify" placeholder="Search menu" v-model="searchWord" @keydown.enter="testFunc" @click:append="testFunc"></v-text-field>

        </v-container>
            </v-sheet>
        </section>

    </div>
</template>
<script>
export default {
    name: 'Search',
    data(){
        return {
            test: "",
            searchWord: ""

        }
    },

     watch: {
        "$route.query.q":{
            immediate: true,
            handler(query){

                console.log("Something" + query);
                
            }
        }
     },

    methods: {
        testFunc() {

            this.$router.push({ name: 'search', query: { q: this.searchWord }})
        }
    }
}
</script>
<style scoped>
.search {
    background-color: #212121;
    width: 100%;
}
</style>