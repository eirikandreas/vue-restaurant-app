<template>
  <div>
    <v-list-item @click="openMessage(item)">
      <template v-if="!isRead">
        <div class="unread mr-5"></div>
      </template>

      <v-list-item-content>
        <v-list-item-title v-text="subject"></v-list-item-title>
        <v-list-item-subtitle class="text--primary" v-text="subject"></v-list-item-subtitle>
        <v-list-item-subtitle v-text="comment"></v-list-item-subtitle>
      </v-list-item-content>

      <v-list-item-action>
        <v-list-item-action-text v-text="date"></v-list-item-action-text>
      </v-list-item-action>

      </v-list-item>

        <MessageDialog
        :active="dialog"
        :message="item"
        @delete-message="deleteMessage"
        @close-dialog="close"
        />

</div>
</template>
<script>
import MessageDialog from '@/components/dashboard/MessageDialog'
export default {
  name: 'InboxItem',
  components: {
    MessageDialog
  },
  props: {
    item: {type: Object },
    inboxData: {type: Array },
    subject: { type: String, default: 'Not Set'},
    name: { type: String, default: 'Not Set'},
    comment: { type: String, default: 'Not Set'},
    date: {type: String, default: "Not Set"},
    read: {type: Boolean, default: false }
  },
  data() {
    return {
      dialog: false,
    }
  },
  methods: {
    openMessage(item) {
      if(item.isRead == false) {
        item.isRead = true
        this.isRead(item)
      }
      this.message = Object.assign({}, item)
      this.dialog = true   
    },
    isRead(message){
      let webAPIUrl = "https://localhost:5001/admin/contactmessages/";
      this.$http.put( webAPIUrl, message )
      console.log("SAVE");
      console.log(message)
    },
    close(){
      this.dialog = false
    },
    deleteMessage(item) {
      const index = this.inboxData.indexOf(item)
      this.inboxData.splice(index, 1)
      this.dialog = false;
      let webAPIUrl = `https://localhost:5001/admin/contactmessages/${item.id}`;
      this.$http.delete(webAPIUrl)
    }
  }
}
</script>
<style scoped>
.height {
  height: 100px;
}
.unread {
  border-radius: 100%;
  width: 12px;
  height: 12px;
  background-color: red;
}
.buttons-position {
  position: absolute;
  bottom: 0;
  right: 0;
  padding-bottom: 10px;
  padding-right: 10px;
}
</style>