<template>
    <div>
        <h2>Register</h2>
        <v-layout>
            <v-flex xs6 offset-xs3>
                <v-card>
                    <v-card-text>
                        <v-text-field
                        v-model="register.FirstName"
                        label="Fornavn"
                        required
                        >
                        
                        </v-text-field>
                        <v-text-field
                        v-model="register.LastName"
                        label="Etternavn"
                        required
                        >
                        
                        </v-text-field>
                        <v-text-field
                        v-model="register.adress"
                        label="Adresse"
                        required
                        >
                        
                        </v-text-field>
                        <v-text-field
                        v-model="register.Phonenumber"
                        label="Telefonnummer"
                        required
                        >
                        
                        </v-text-field>
                        <v-text-field
                        v-model="login.email"
                        label="Epost"
                        required
                        >
                        </v-text-field>

                        <v-text-field
                        v-model="login.password"
                        label="Passord"
                        type="password"
                        required
                        >

                        </v-text-field>
                    </v-card-text>
                    <v-btn rounded color="amber accent-3 black--text" class="ml-4" dark min-width="150px" depressed>Registrer deg</v-btn>
                </v-card>
            </v-flex>




        </v-layout>    
        
    </div> 
</template>
<script>
export default {
    name: 'Register',
    data(){
        return{
            register:{
                FirstName:"",
                LastName:"",
                Adress:"",
                PhoneNumber:"",
                Email:"",
                Password:""
            }
        }
    }
    
}
</script>