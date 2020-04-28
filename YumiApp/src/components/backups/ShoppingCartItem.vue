<template>
    <div>
  



      <v-divider></v-divider>
            <v-list-item>
              <v-list-item-avatar>
                <v-img :src="`https://localhost:5001/images/${image}`"></v-img>
              </v-list-item-avatar>

              <v-list-item-content>
                <v-list-item-title>{{ title }} </v-list-item-title>
                <v-list-item-subtitle>Price ${{ price }}</v-list-item-subtitle>
                 <v-list-item-subtitle>Quantity {{ quantity }}</v-list-item-subtitle>
              </v-list-item-content>
        
              <v-btn icon @click.stop="deleteItem(index)">
                <v-icon small>mdi-close</v-icon>
              </v-btn>
            
            </v-list-item>



    </div>
</template>
<script>
export default {
    name: 'CartItem',
    props: {
        image: {type: String, default: 'default.jpg'},
        title: {type: String, default: 'Not Set'},
        price: {type: Number, default: 0 },
        index: {type: Number, default: 0 },
        method: { type: Function },
        quantity: {type: Number, default: 1}
    },
    methods: {
        deleteItem(index) {
            this.$emit('delete-item', index)

        },
        
        
    
    }
}
</script>