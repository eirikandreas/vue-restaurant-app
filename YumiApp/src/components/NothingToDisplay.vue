<template>
    <div>
       
            <v-row>
                <v-col>
                    <v-card flat min-height="300px" class="d-flex align-center justify-center">

                            <h1 class="display-2 grey--text"> Nothing to display</h1>

                    </v-card>
                </v-col>
            </v-row>
  

    </div>
</template>

<script>
export default {
    name: 'NothingToDisplay',
    props: {
        array: { type: Array },
    }
}
</script>