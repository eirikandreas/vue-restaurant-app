<template>
    <div class="text-md-center">
        <h2>Login</h2>
        <v-layout>
            <v-flex xs6 offset-xs3>
                <v-card>
                    <v-card-text>
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
                    <v-btn rounded color="amber accent-3 black--text" class="ml-4" dark min-width="150px" depressed>Log in</v-btn>
                    <v-btn rounded color="amber accent-3 black--text" class="ml-4" dark min-width="150px" depressed>Registrer deg</v-btn>
                </v-card>
            </v-flex>




        </v-layout>
        
    
    </div> 
</template>

<script>
export default {
    name: 'Login',
    data(){
        return{
            login:{
                email:"",
                password:""
            }
        }
    }
    
}
</script>