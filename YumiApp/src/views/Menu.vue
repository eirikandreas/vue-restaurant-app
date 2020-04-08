<template>
  <div>
    <v-parallax height="300" width="500" dark :src="require(`@/assets/images/${sectionParallaxImg}`)">
      <v-row
      align="center"
      justify="center"
      id="overlay-image"
      class="ml-n4 mr-n4"
      >
        <v-col class="text-center  d-flex flex-column align-center" cols="12">
          <v-img class="align-center" :src="require(`@/assets/icons/${sectionParallaxIcon}`)" width="64" height="64"></v-img>
            <h1 class="display-4 font-weight-thin mb-4">Our menu</h1>
        </v-col>
      </v-row>
    </v-parallax>

    <v-container fluid style="backgroundColor: #f3f3f4">
      <v-container>
        <v-text-field id="searchID" rounded outlined clearable append-icon="mdi-magnify" @click:append="`/maki/`" label="Search menu" v-model="searchTerm" :to="`/maki/`"></v-text-field>
          <v-tabs grow background-color="transparent" icons-and-text color="red">
            <v-tab class="pb-3"  @click="getAll()" :to="`/menu/`">
              All
              <v-img contain :src="require(`@/assets/icons/menu.png`)" width="32" height="32"></v-img>
            </v-tab>
            <v-tab v-for="category in categories" :key="category.id" @click="getCategory(category.name)" :to="`/menu/${category.name.toLowerCase()}`" class="pb-3">
              {{category.name}}
              <v-img contain :src="require(`@/assets/icons/${category.blackIcon}`)" width="32" height="32"></v-img>
            </v-tab>
          </v-tabs>
      </v-container>
    </v-container>

    <v-container>
    <!-- TEST SEARCH COMPONENT -->
    <!--

         <MenuList
    :searchTerm="searchTerm"
    :displayItems="display"
    :getList="menuItems"
    />

    -->
      <router-view/>
  
    </v-container>

  </div>     
</template>
<script>

export default {
    name: 'Menu',
    data () {
      return {
        display: 4,
        menuItems: [{}],
        searchTerm: "",
        sectionParallaxImg: 'parallax-5.jpg',
        sectionParallaxIcon: 'takeaway-w.png',
        categories: this.$categories.get()
      }
    }, 
    methods: {
      getCategory(e) {
      const webAPIUrl = `https://localhost:5001/menuitems/category/${e}`;
      this.$http.get(webAPIUrl)
        .then( response => {
          this.menuItems = response.data;
        });
      },
      getAll(){
      let webAPIUrl = "https://localhost:5001/menuitems";
      this.$http.get( webAPIUrl )
        .then( result => {
          console.log( result.data );
          this.menuItems = result.data;
        })            
      }
    },
    created(){
      this.getAll()
    }
}
</script>
<style scoped>
#overlay-image {
  background-color: rgba(0, 0, 0, 0.6);
}
.v-parallax__content {
    padding: 0;
}
</style>