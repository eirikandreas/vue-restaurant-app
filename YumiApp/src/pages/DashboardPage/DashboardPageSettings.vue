<template>
  <div>    

    <v-toolbar flat color="transparent">
      <v-toolbar-title class="headline ml-n4">Page Settings</v-toolbar-title>
    </v-toolbar>
    
    <v-card block class="mb-5">

      <template v-if="loading">
        <AppLoader/>
      </template>

      <template v-else>

        <template v-if="nothingToDisplay">

          <NothingToDisplay
          text="Could not connect to API"
          />
        
        </template>

        <template v-else>

        <v-row>
          <v-col cols="12" md="12" lg="12">
            <v-list>

              <v-subheader class="title">Home Page</v-subheader>

              <v-list-item>
                <v-row>
                  <v-col cols="12" sm="4" class="d-flex">
                    <v-subheader class="font-weight-bold">Display Carousel</v-subheader>    
                  </v-col>
                  <v-col cols="12" sm="8" class="d-flex align-center">
                    <v-switch v-model="pageSettings.homeDisplayCarousel" inset color="amber accent-3" class="pt-3 ma-0"></v-switch>
                    <v-list-item-subtitle class="pb-3">(Must have 3 Featured Menu Items)</v-list-item-subtitle>
                  </v-col>
                </v-row>
              </v-list-item>

              <v-list-item>
                <v-row>
                  <v-col cols="12" sm="4" class="d-flex">
                    <v-subheader class="font-weight-bold">Display Top Picks Section</v-subheader>    
                  </v-col>
                  <v-col cols="12" sm="8">
                    <v-switch v-model="pageSettings.homeDisplayTopPicks" inset color="amber accent-3" class="pt-3 ma-0"></v-switch>
                  </v-col>
                </v-row>
              </v-list-item>

              <v-list-item>
                <v-row>
                  <v-col cols="12" sm="4">
                    <v-subheader class="font-weight-bold">Hero title</v-subheader>
                  </v-col>
                  <v-col cols="12" sm="8">
                    <v-text-field
                    color="amber accent-3"
                    outlined
                    label="Type about text"
                    v-model="pageSettings.homeHeroTitle"
                    ></v-text-field>
                  </v-col>
                </v-row>
              </v-list-item>

              <v-list-item>
                <v-row>
                  <v-col cols="12" sm="4">
                    <v-subheader class="font-weight-bold">Title</v-subheader>
                  </v-col>
                  <v-col cols="12" sm="8">
                    <v-text-field
                    color="amber accent-3"
                    outlined
                    label="Type about text"
                    v-model="pageSettings.homeTitle"
                    ></v-text-field>
                  </v-col>
                </v-row>
              </v-list-item>

              <v-list-item>
                <v-row>
                  <v-col cols="12" sm="4">
                    <v-subheader class="font-weight-bold">Text Section 1</v-subheader>
                  </v-col>
                  <v-col cols="12" sm="8">
                    <v-textarea
                    color="amber accent-3"
                    outlined
                    label="Type about text"
                    v-model="pageSettings.homeText"
                    ></v-textarea>
                  </v-col>
                </v-row>
              </v-list-item>

            </v-list>
          </v-col>
          </v-row>

          <v-divider></v-divider>
    
          <v-row>
            <v-col cols="12" md="12" lg="12">
              <v-list>
                <v-subheader class="title">Menu Page</v-subheader>
                <v-list-item>
                  <v-row>
                    <v-col cols="12" sm="4">
                      <v-subheader class="font-weight-bold">Header</v-subheader>
                    </v-col>
                    <v-col cols="12" sm="8">
                      <v-text-field
                      color="amber accent-3"
                      outlined
                      label="Type about text"
                      v-model="pageSettings.menuHeaderTitle"
                      ></v-text-field>
                    </v-col>
                  </v-row>
                </v-list-item>
              </v-list>
            </v-col>
          </v-row>

          <v-divider></v-divider>

          <v-row>
          <v-col cols="12" md="12" lg="12">
            <v-list>
              <v-subheader class="title">About Page</v-subheader>
              <v-list-item>
                <v-row>
                  <v-col cols="12" sm="4">
                    <v-subheader class="font-weight-bold">Header</v-subheader>
                  </v-col>
                  <v-col cols="12" sm="8">
                    <v-text-field
                    color="amber accent-3"
                    outlined
                    label="Type about text"
                    v-model="pageSettings.aboutHeaderTitle"
                    ></v-text-field>
                  </v-col>
                </v-row>
              </v-list-item>

              <v-list-item>
                <v-row>
                  <v-col cols="12" sm="4">
                    <v-subheader class="font-weight-bold">Title</v-subheader>
                  </v-col>
                  <v-col cols="12" sm="8">
                    <v-text-field
                    color="amber accent-3"
                    outlined
                    label="Type about text"
                    v-model="pageSettings.aboutTitle"
                    ></v-text-field>
                  </v-col>
                </v-row>
              </v-list-item>

              <v-list-item>
                <v-row>
                  <v-col cols="12" sm="4">
                    <v-subheader class="font-weight-bold">Text Section 1</v-subheader>
                  </v-col>
                  <v-col cols="12" sm="8">
                    <v-textarea
                    color="amber accent-3"
                    outlined
                    label="Type about text"
                    v-model="pageSettings.aboutText1"
                    ></v-textarea>
                  </v-col>
                </v-row>
              </v-list-item>

              <v-list-item>
                <v-row>
                  <v-col cols="12" sm="4">
                    <v-subheader class="font-weight-bold">Text Section 2</v-subheader>
                  </v-col>
                  <v-col cols="12" sm="8">
                    <v-textarea
                    color="amber accent-3"
                    outlined
                    label="Type about text"
                    v-model="pageSettings.aboutText2"
                    ></v-textarea>
                  </v-col>
                </v-row>
              </v-list-item>

            </v-list>
          </v-col>
        </v-row>

        <v-divider></v-divider>
        <v-row>
          <v-col cols="12" md="12" lg="12">
            <v-list>
              <v-subheader class="title">Contact Page</v-subheader>

              <v-list-item>
                <v-row>
                  <v-col cols="12" sm="4">
                    <v-subheader class="font-weight-bold">Header</v-subheader>
                  </v-col>
                  <v-col cols="12" sm="8">
                    <v-text-field
                    color="amber accent-3"
                    outlined
                    label="Type about text"
                    v-model="pageSettings.contactHeaderTitle"
                    ></v-text-field>
                  </v-col>
                </v-row>
              </v-list-item>

              <v-list-item>
                <v-row>
                  <v-col cols="12" sm="4">
                    <v-subheader class="font-weight-bold">Title</v-subheader>
                  </v-col>
                  <v-col cols="12" sm="8">
                    <v-text-field
                    color="amber accent-3"
                    outlined
                    label="Type about text"
                    v-model="pageSettings.contactTitle"
                    ></v-text-field>
                  </v-col>
                </v-row>
              </v-list-item>

              <v-list-item>
                <v-row>
                  <v-col cols="12" sm="4">
                    <v-subheader class="font-weight-bold">Text</v-subheader>
                  </v-col>
                  <v-col cols="12" sm="8">
                    <v-textarea
                    color="amber accent-3"
                    outlined
                    label="Type about text"
                    v-model="pageSettings.contactText"
                    ></v-textarea>
                  </v-col>
                </v-row>
              </v-list-item>

            </v-list>
          </v-col>
        </v-row>

        <v-list-item>
          <v-btn rounded color="amber accent-3" depressed absolute right @click.stop="dialog = true">Submit</v-btn>
        </v-list-item>

      </template>
    
    </template>
  </v-card>

    <ConfirmSettingsDialog
    :active="dialog"
    @save-changes="savePageSettings"
    @close-dialog="closeDialog"
    />

  </div>  
</template>
<script>
import AppLoader from '@/components/common/AppLoader'
import NothingToDisplay from '@/components/common/NothingToDisplay'
import ConfirmSettingsDialog from '@/components/dashboard/ConfirmSettingsDialog'
export default {
    name: 'Settings',
    components: {
      NothingToDisplay,
      AppLoader,
      ConfirmSettingsDialog
    },
    data() {
        return {
          loading: false,
          nothingToDisplay: false,
          dialog: false,
          pageSettings: {},
          defaultPageSettings: {
          homeDisplayCarousel: false,
          homeDisplayTopPicks: false,
          homeHeroTitle: "Order, eat, enjoy!",
          homeFavTitle: 'Top Picks',
          homeTitle: "Our Concept",
          homeText: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Incidunt ipsum minus non vel ut est ab ducimus quod? Enim, architecto.",
          menuHeaderTitle: "Our Menu",
          aboutHeaderTitle: "About Us",
          aboutText1: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Incidunt ipsum minus non vel ut est ab ducimus quod? Enim, architecto.",
          aboutText2: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Incidunt ipsum minus non vel ut est ab ducimus quod? Enim, architecto.",
          contactHeaderTitle: "Contact Us",
          contactTitle: "",
          contactText: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Incidunt ipsum minus non vel ut est ab ducimus quod? Enim, architecto."
        }
      }
    },
     methods: {
      /* 
      Sjekk om objektet er tomt. Object.keys returnerer et Array med properties,
      Objektet er tomt hvis lengden er 0.
      */
      isEmpty(obj) {
        return Object.keys(obj).length === 0;
      },
      // Initialiserer pageSettings objektet
      initialize() {
        this.pageSettings = {}  
      },

      //Skriver default verdier til Pagesettings
      postPageSettings() {
        let webAPIUrl = "https://localhost:5001/admin/pagesettings";
        this.$http.post(webAPIUrl, this.defaultPageSettings)
      },
      /*
      Henter ut spesifikk data med id 1 til applikasjonen fra APIet
      Hvis den speifikke oppføringen ikke eksisterer, kjør post-funksjon
      */
      getPageSettings() {
        this.loading = true
        this.initialize()
        let webAPIUrl = "https://localhost:5001/admin/pagesettings/1";
        this.$http.get( webAPIUrl )
          .then( response => { 
                this.pageSettings = response.data;

                if(this.isEmpty(this.pageSettings)) {
                  this.postPageSettings()
                }
                this.loading = false        
          })
          .catch(error => {
                this.loading = false,
                this.nothingToDisplay = true
                console.log(error.response)

          })             
      },
      //Lagrer dataene fra pageSettings objektet til APIet
      savePageSettings() {
        let webAPIUrl = "https://localhost:5001/admin/pagesettings";
        this.$http.put( webAPIUrl, this.pageSettings )
        this.getPageSettings()
        this.dialog = false;       
      },
      closeDialog() {
        this.dialog = false
      }
    },
    created() {
      this.getPageSettings()
    } 
}
</script>