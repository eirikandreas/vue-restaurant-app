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
            searchWord: null,
            lastSearchWord: null
        }
    },
    methods: {
        /*
        Sjekker om det forrige søkeordet er likt som query i routen,
        Unngår med dette å duplikere samme route dersom en bruker søker etter samme ord.
        */
        search() {
            if(this.lastSearchWord != this.$route.query.q) {
                this.$router.push({ name: 'search', query: { q: this.searchWord }})
            }
            this.lastSearchWord = this.searchWord
        }
    }
}
</script>