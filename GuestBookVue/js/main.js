new Vue({
    el: '#app',
    data: {
        notes: null,        

        url: {
            getComment: 'https://localhost:5000/GuestBook/GetComments/',
            postComment:'https://localhost:5000/GuestBook/PostComment/'
        },
       errors: [],
            name: null,
            comment: null,
            rating: 8,
            email: null,
            date: null,
        open: false
    },
    methods: {
        openBlock() {
            this.open= ! this.open
        },

        cleanF() {
            this.name= null;
            this.comment = null;
            this.rating = 8;
            this.email = null;
            this.date = null;
        },
        getUnits() {
            axios.get(this.url.getComment).then((response) => {
                console.log(response.data);
                this.notes = response.data.reverse();
            })
        },
        onSubmit: function (e) {
             this.errors = [];
                if (this.name && this.comment ) {
                    axios.post(this.url.postComment, { name: this.name, rating: parseInt(this.rating, 10), comment: this.comment, email: this.email }).then((response) => {
                        console.warn(response);
                    });
                   this.cleanF();
                    this.getUnits();
                    return true;
                }

               

                if (!this.name) {
                    this.errors.push('A name is required.');
            }
            
                if (!this.comment) {
                    this.errors.push('A comment is required.');
                }

                e.preventDefault();

          
        
            }
    },
  
    created: function () {
        
        this.getUnits()
    }

})


