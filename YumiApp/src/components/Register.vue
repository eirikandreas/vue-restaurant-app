<template>
  <v-app id="Register">
    <v-content>
      <v-container
        class="fill-height"
        fluid
      >
        <v-row
          align="center"
          justify="center"
        >
          <v-col
            cols="12"
            sm="8"
            md="4"
          >
            <v-card class="elevation-12">
              <v-toolbar
                color="amber accent-3 black--text"
                dark
                flat
                bold
              >
                <v-toolbar-title class="font-weight-bold" >Registrer ny bruker</v-toolbar-title>
                <v-spacer />
                <v-tooltip bottom>
                  <template v-slot:activator="{ on }">
                    <v-btn
                      :href="source"
                      icon
                      large
                      target="_blank"
                      v-on="on"
                    >
                    </v-btn>
                  </template>
               
                
                </v-tooltip>
              </v-toolbar>
              <v-card-text>
                <v-form>
                  <v-text-field
                    v-model="newUser.FirstName"
                    label="Fornavn"
                    name="FirstName"
                    type="text"
                  />
                  <v-text-field
                    v-model="newUser.LastName"
                    label="Etternavn"
                    name="LastName"
                    type="text"
                  />
                  <v-text-field
                    v-model="newUser.adress"
                    label="Adresse"
                    name="adress"
                    type="text"
                  />
                  <v-text-field
                    v-model="newUser.phonenumber"
                    label="Telefonnummer"
                    name="phonenumber"
                    type="text"
                  />
                  <v-text-field
                    v-model="newUser.email"
                    label="Epost"
                    name="email"
                    type="text"
                  />
                  <v-text-field
                    v-model="newUser.password"
                    label="Passord"
                    name="password"
                    type="password"
                  />
                  <p>
                    {{postStatus}}
                  </p>
                </v-form>
              </v-card-text>
              <v-card-actions>
                <v-spacer />
                <v-btn @click="email" to="/login" rounded color="amber accent-3 black--text" class="ml-4" dark min-width="150px" depressed>Opprett ny bruker</v-btn>
              </v-card-actions>
            </v-card>
          </v-col>
        </v-row>
      </v-container>
    </v-content>
  </v-app>
</template>

<script>
import axios from 'axios'
export default {
    name: 'Register',
    data(){
      return{
        newUser: { FirstName: "", LastName: "", adress: "", phonenumber: "", email: "", password: ""},
        postStatus: "Ny bruker er ikke lagret"
      }
    },
    methods:{
      email(){
        let webAPIUrl ="https://localhost:5001/users";
        axios.post (webAPIUrl, this.newUser)
        .then ( result =>{
          this.postStatus = JSON.stringify (result.data);
          console.log (result.data);
        })

      }
    }

}
</script>

