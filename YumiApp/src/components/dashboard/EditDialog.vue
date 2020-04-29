<template>

        <v-dialog :value="active" :fullscreen="$vuetify.breakpoint.xsOnly" v-model="active" persistent max-width="800px">
            <v-card class="mx-auto">
                <v-form ref="form" v-model="valid" lazy-validation>
                    <v-container>
                        <v-card-title class="headline">Add menu item</v-card-title>
                        <v-row>
                            <v-col cols="12" sm="6" class="mb-0 pb-0">
                                <v-text-field dense outlined color="amber accent-3" v-model="editedItem.title" label="Title" :rules="reqRule"></v-text-field>
                            </v-col>

                            <v-col cols="12" sm="3" class="mb-0 pb-0">
                                <v-select dense v-model="editedItem.category" :items="categories" color="amber accent-3" label="Select category" outlined :rules="reqRule"></v-select>
                            </v-col>

                            <v-col cols="12" sm="3" class="mb-0 pb-0">
                                <v-text-field dense outlined v-model="editedItem.price" color="amber accent-3" type="number" label="Price" :rules="reqRule"></v-text-field>
                            </v-col>

                            <v-col cols="12" sm="6" class="mb-0 pb-0">
                                <v-textarea outlined dense height="105" v-model="editedItem.description" color="amber accent-3" label="Description" :rules="reqRule"></v-textarea>
                            </v-col>


                            <v-col cols="12" sm="6" class="mb-0 pb-0">
                                <v-textarea outlined dense height="105" v-model="editedItem.ingredients" color="amber accent-3" label="Ingredients" :rules="reqRule"></v-textarea>
                            </v-col>

                            <v-col cols="12" sm="12" class="mb-0 pb-0">

                                <v-text-field
                                outlined
                                v-model="editedItem.allergens"
                                color="amber accent-3"
                                label="Allergens"
                                :rules="reqRule"
                                ></v-text-field>  
                            </v-col>
    
                            <v-col cols="12" md="12" class="mb-0 pb-0">
                                <v-file-input 
                                counter 
                                :show-size="1000"
                                outlined label="File input" 
                                placeholder="Upload your documents" 
                                prepend-icon="mdi-camera" 
                                id="file" 
                                name="file" 
                                accept="image/*" 
                                ></v-file-input>
                            </v-col>
                
                            <v-col cols="12" md="12" class="mb-0 pb-0">
                                <v-card flat outlined>
                                    <v-card-text class="d-flex pb-0 pt-0">
                                        <v-switch v-model="editedItem.isSpicy" inset :label="`Add spicy notification`" class="pr-5"></v-switch>
                                        <v-switch v-model="editedItem.isFeatured" inset :label="`Set featured on frontpage`"></v-switch>
                                    </v-card-text>
                                </v-card>
                            </v-col>
                        </v-row>
 
                        <v-card-actions>
                            <v-spacer></v-spacer>
                           
                            <v-btn rounded depressed color="amber accent-3" @click="close">Cancel</v-btn>
                            <v-btn :disabled="!valid" rounded depressed color="amber accent-3" @click="validate()">Save</v-btn>
                            
                        </v-card-actions>
          
                    </v-container>
                </v-form>
            </v-card>
        </v-dialog>

</template>

<script>
export default {
    name: 'EditDialog',
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
        }
    },
    data() {
        return {
             valid: false,
             reqRule: [
                v => !!v || 'This field is required'
            ],
            categories: this.$categories.getName().slice(1, 7),
            file: "",
        } 
    },
    methods: {
           validate () {
                if(this.$refs.form.validate() == true) {
                   this.save()
                } else {
                    this.$refs.form.validate()
                }
            },

            resetValidation() {
                this.$refs.form.reset()
            },
            //$emit tillater bruk av funksjoner fra parent-component i child-component.
            close() {
                this.$emit('close-dialog')
            },
            /* 
            Sender oppdatert informasjon tilbake til parent-komponenten
            kjører så uploadImage.
            */
            save() {
                if (this.editedItemIndex > -1) {
                    this.$emit('save-item', {editedItemIndex: this.editedItemIndex, editedItem: this.editedItem})
                    this.uploadImage()
                
                } else {
                    this.$emit('new-item', this.editedItem)
                    this.uploadImage()
                }
                this.close()
            },
            uploadImage(){
                this.file = document.getElementById("file");
                let data = new FormData();  
                data.append( "file", this.file.files[0] );
                if(this.file.value == "") { 
                    this.editedItem.imgSrc = "default.jpg";
                } else {
                    this.$http({
                        method: 'post',
                        url: "https://localhost:5001/admin/savepicture",
                        data: data,
                        config: { headers: {'Content-Type': 'mulitpart/form-data'}}
                    });
                    this.editedItem.imgSrc = this.file.files[0].name;
                }
            }
    }
}
</script>