<template>
  <div>
    <v-list-item>
      <v-list-item-avatar>
        <v-img :src="`https://localhost:5001/images/${image}`"></v-img>
      </v-list-item-avatar>
      
      <v-list-item-content>
        <v-list-item-title>{{ title }} </v-list-item-title>
        <v-list-item-subtitle>Price ${{ price }}</v-list-item-subtitle>
        <v-list-item-subtitle>Quantity {{ quantity }}</v-list-item-subtitle>
      </v-list-item-content>
      
      <template v-if="showDelete">
        <v-btn icon @click.stop="deleteItem(index)">
          <v-icon small>mdi-close</v-icon>
        </v-btn>
      </template>
    </v-list-item>
  </div>
</template>
<script>
export default {
  name: 'ShoppingCartItem',
  props: {
      image: {type: String, default: 'default.jpg'},
      title: {type: String, default: 'Not Set'},
      price: {type: Number, default: 0 },
      index: {type: Number },
      method: { type: Function },
      quantity: {type: Number, default: 1},
      showDelete: {type: Boolean, default: true}
  },
  methods: {
    //$emit tillater bruk av funksjoner fra parent-component i child-component.
    deleteItem(index) {
      this.$emit('delete-item', index)
    },
  }
}
</script>