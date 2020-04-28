<template>
    <section id="category" style="backgroundColor: #f3f3f4">

        <v-container class="pb-0 pt-0">
          <v-tabs grow background-color="transparent" icons-and-text color="red" height="100px" show-arrows>
            <v-tab class="pb-3 pt-3" v-for="(category, index) in categories" :key="index" :to="`/menu/${category.name.toLowerCase()}`">
              {{category.name}}
              <v-img contain :src="require(`@/assets/icons/${category.blackIcon}`)" width="32" height="32"></v-img>
            </v-tab>
          </v-tabs>
        </v-container>

    </section>
</template>

<script>
export default {
    name: 'MenuCategories',
    data() {
        return {
            categories: this.$categories.getAll()
        }
    },
}
</script>