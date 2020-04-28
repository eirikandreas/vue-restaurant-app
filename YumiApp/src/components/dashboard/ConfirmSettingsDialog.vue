<template>
    <v-dialog v-model="active" max-width="600">
        <v-card>
        <v-card-title class="headline">Submit changes</v-card-title>

        <v-card-text>
          This will apply changes to the web page settings. Do you want to continue?
        </v-card-text>

        <v-card-actions>
        <v-spacer></v-spacer>

          <v-btn
          color="amber accent-3"
          depressed
          rounded
        
          @click="close"
          >
          Cancel
          </v-btn>

          <v-btn
          color="amber accent-3"
          depressed
          rounded
          @click="save"
          >
          Submit
          </v-btn>
          
        </v-card-actions>

        </v-card>
    </v-dialog>
</template>
<script>
export default {
    name: 'ConfirmSettingsDialog',
    props: {
        active: { type: Boolean, default: false},
        closeDialog: { type: Object },
        savePageSettings: { type: Object}
    },
    methods: {
        save() {
            this.$emit('save-changes')
        },
        close() {
            this.$emit('close-dialog')
        }
    }
}
</script>