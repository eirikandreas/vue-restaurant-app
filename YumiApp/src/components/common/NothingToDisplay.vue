<template>
    <div>
        <v-row>
            <v-col>
                <v-card flat min-height="290px" class="d-flex align-center justify-center">
                        <h1 class="display-2 grey--text">{{text}}</h1>
                </v-card>                
            </v-col>
        </v-row>
    </div>
</template>

<script>
export default {
    name: 'NothingToDisplay',
    props: {
        text: { type: String, default: "Nothing To Display"}
    }
}
</script>