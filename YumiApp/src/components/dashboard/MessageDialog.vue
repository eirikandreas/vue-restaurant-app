<template>
    <div>
      <v-dialog :value="active" v-model="active" max-width="690">
        <v-card min-height="400px">
          <v-sheet color="grey lighten-3">
            <v-list-item>
              <v-card-title class="headline">{{message.subject}}</v-card-title>

              <template v-if="message.contactByPhone">

                <v-row align="center" justify="end">
                  <v-chip class="ma-2 white--text" color="red">
                    <v-icon small class="mr-2">mdi-phone</v-icon>
                      Contact by phone
                  </v-chip>
                </v-row>
  
              </template>

            </v-list-item>
          </v-sheet>

        <v-divider></v-divider>

        <v-list-item>
          <v-card-subtitle>
            From: {{message.name}}, {{message.email}}, {{message.phoneNumber}}
          </v-card-subtitle>
          
          <v-row align="center" justify="end">
            <v-card-subtitle>Recieved: {{message.dateSent}} </v-card-subtitle>
          </v-row>
        </v-list-item>
        
        <v-divider></v-divider>

        <v-list-item>
          <v-card-text>{{message.comment}}</v-card-text>
        </v-list-item>

          <v-card-actions>
            <div class="buttons-position">
              <v-btn
              color="amber accent-3"
              rounded
              depressed
              @click="close()"
              class="mr-3"
              >
              Cancel
              </v-btn>

              <v-btn
              color="amber accent-3"
              rounded
              depressed
              @click="deleteItem(message)"
              >
              Delete
              </v-btn>
            </div>
          </v-card-actions>

        </v-card>
      </v-dialog>

    </div>
</template>
<script>
export default {
    name: 'MessageDialog',
     props: {
        active: {
            type: Boolean,
            required: true,
            default: false
        },
        message: {
            type: Object,
            required: true
        },
        closeDialog: {
            type: Object,
        },
        deleteMessage: {
            type: Object,
        }
    },
    methods: {
        close() {
            this.$emit('close-dialog')
        },
        deleteItem(message) {
            this.$emit('delete-message', message)
        }
    }
}
</script>