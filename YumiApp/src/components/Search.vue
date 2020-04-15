<template>
    <div>
        <v-container>
        <v-text-field outlined rounded clearable color="amber accent-3" append-icon="mdi-magnify" placeholder="Search menu" v-model="searchWord" @keydown.enter="testFunc" @click:append="testFunc"></v-text-field>
        </v-container>

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