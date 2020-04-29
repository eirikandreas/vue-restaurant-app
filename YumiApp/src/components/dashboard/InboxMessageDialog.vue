<template>
  <v-dialog persistent :value="active" v-model="active" max-width="690">
    <v-card min-height="400px">
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

      <v-divider></v-divider>

      <v-list-item>
        <v-card-subtitle>
          From:
          {{message.name}}, {{message.email}}, {{message.phoneNumber}}
        </v-card-subtitle>
        
        <v-row align="center" justify="end">
          <v-card-subtitle>Recieved: {{message.dateSent}} </v-card-subtitle>
        </v-row>
      </v-list-item>

      <v-divider></v-divider>

      <v-list-item>
        <v-card-text>
          {{message.comment}}
        </v-card-text>

      </v-list-item>
      
      <v-card-actions>
        <div class="buttons-position">

          <v-btn
            color="amber accent-3"
            rounded
            depressed
            @click="dialog = false"
            class="mr-3"
          >
            Cancel
          </v-btn>

          <v-btn
            color="amber accent-3"
            rounded
            depressed
            @click="deleteMessage(message)"
          >
            Delete
          </v-btn>
        </div>
      </v-card-actions>
      
    </v-card>
  </v-dialog>
</template>
<script>
export default {
  name: 'InboxMessageDialog',
  props: {
    active: { 
      type: Boolean,
      required: true,
      default: false
    },
    editedItemIndex: {
      type: Number,
      required: true,
      default: -1
    },
    editedItem: {
      type: Object,
      required: true
    },
    closeDialog: {
      type: Object,
    },
  },
}
</script>