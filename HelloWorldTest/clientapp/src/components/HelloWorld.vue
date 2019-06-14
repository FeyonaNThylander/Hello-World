<template>
    <div class="hello">
        <h1>{{ msg }}</h1>
        <h3>Hello world test</h3>
        <br />
        <br />
        <hr />
        <form @submit="sendInput">
            <p>Enter your name</p>
            <input type="text" v-model="UserInput" placeholder="Enter your name" />
            <button>Send</button>
        </form>
        <br /> 
        <strong>Message:</strong> {{ output }}
        <br />
        <br />
        <br />
    </div>
</template>

<script>
    export default {
        name: "HelloWorld",
        props: {
            msg: String
        },
        mounted() {
            console.log("Component mounted!")
        },
        data() {
            return {
                UserInput: '',
                output: ''
            };
        },
        methods: {
            sendInput(e) {
                let currentObj = this;
                e.preventDefault();
                //alert("Something happend + " + currentObj.output),
                this.axios.post('https://localhost:44309/api/User/Input', {
                    UserInput: this.UserInput,
                    output: this.output
                })
                    .then(response => {
                        currentObj.output = response.data;
                        //console.log("The server says hello " + response.data);
                    })
                    .catch(error => {
                        currentObj.output = error;
                    });
            }
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    h3 {
        margin: 40px 0 0;
    }

    ul {
        list-style-type: none;
        padding: 0;
    }

    li {
        display: inline-block;
        margin: 0 10px;
    }

    a {
        color: #42b983;
    }
</style>
