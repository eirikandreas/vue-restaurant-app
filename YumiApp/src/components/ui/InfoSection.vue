<template>
     <v-container>
      <v-row>
        <v-col cols="12" sm="12" md="6" class="d-flex align-center pa-0 hidden-sm-and-down">
            <v-img contain :src="require(`@/assets/images/${image}`)" max-height="400">
            </v-img>
  
        </v-col>

        <v-col cols="12" sm="12" md="6" class="d-flex align-center justify-center">

          <v-card flat :class="{'text-center mb-6': $vuetify.breakpoint.smAndDown}">
            <v-card-title 
            :class="[{'justify-center display-2': $vuetify.breakpoint.smAndDown}, 'display-3', 'font-weight-bold']"
            >
            {{title}}
            </v-card-title>
            
            <v-card-text>{{text}}</v-card-text>

            <template v-if="twotext">
                <v-card-text>{{text2}}</v-card-text>
            </template>  

            <v-card-text>
              <template v-if="showButton">
                <v-btn depressed rounded large color="amber accent-3" :to="`${link}`">{{buttonValue}}</v-btn>
              </template>
            </v-card-text>

          </v-card>
        </v-col>
      </v-row>
    </v-container>
</template>
<script>
export default {
    name: 'InfoSection',
    props: {
        title: {type: String, default: 'Not Set'},
        text: {type: String, default: 'Not Set'},
        twotext: {tyoe: Boolean, default: false},
        text2: {type: String, default: ''},
        image: {type: String, default: 'concept-image-1-crop.png'},
        showButton: {type: Boolean, default: false},
        buttonValue: {type: String, default: 'Not Set'},
        link: {type: String, default: '#'}
    }
}
</script>