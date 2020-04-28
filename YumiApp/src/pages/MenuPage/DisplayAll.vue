<template>
    <div>
      
      <template v-if="loading">
        <AppLoader/>
      </template>

      <template v-else>

        <MenuList
        :items="menuItems"
        />
        
      </template>

    </div>
</template>

<script>
import AppLoader from '@/components/common/AppLoader'
import MenuList from '@/components/menu/MenuList'
export default {
    name: 'DisplayAll',
    components: {
        AppLoader,
        MenuList
    },
    data() {
        return {
            loading: false,
            menuItems: [{}]
        }
    },
    methods: {
      getAll(){
      this.loading = true;
      let webAPIUrl = "https://localhost:5001/user/menuitems";
      this.$http.get( webAPIUrl )
        .then( result => {
          this.menuItems = result.data;
          this.loading = false;
        })            
      },
    },
    created() {
        this.getAll()
    }
}
</script>