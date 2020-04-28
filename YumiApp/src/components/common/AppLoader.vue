<template>
  <section id="loader" :style="`backgroundColor:${bgColor}; height:${height}px`" class="d-flex align-center flex-column justify-center">
    
    <v-progress-circular
    :size="70"
    :width="12"
    color="red"
    indeterminate
    ></v-progress-circular>
    
    <h1 class="grey--text display-2 pt-5">Loading</h1>
      
  </section>
</template>
<script>
export default {
    name: 'AppLoader',
    props: {
      bgColor: { type: String, default: "#ffffff"},
      height: { type: Number, default: 300}
    }
}
</script>
