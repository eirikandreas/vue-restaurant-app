<template>
    <div id="top"> 
        <v-text-field outlined rounded clearable hide-details dark append-icon="mdi-magnify" placeholder="Search menu" v-model="searchWord" @keydown.enter="search" @click:append="search"></v-text-field>
    </div>
</template>
<script>
export default {
    name: 'Search',
    data(){
        return {
            searchWord: "",
            lastSearchWord: ""
        }
    },
    methods: {
        search() {

                this.$router.push({ name: 'search', query: { q: this.searchWord }})
              
                console.log( "this.lastSearchWord " + this.lastSearchWord );
        }
    }
}
</script>