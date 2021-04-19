import axios from 'axios';

Vue.component('comment', {
    template: `
     <div class="comments">
        <div class="commentItem" v-for="comment in comments">
          <h3>{{comment.Name}} </h3>
          <h4>{{comment.Date}}</h4>

          <hr />
          <p>{{comment.Rating}}</p>
          <p>{{comment.Comment}}</p>
          <hr />
        </div>
      </div>
    `,
    data() {
        return {
            
        }
    }
})

var app = new Vue({
    el: '#app',
    data: {
            nameGuest: null,
            comment: null,
            rating: 5,
            email:null
    },
    methods: {
        onSubmit() {
            let commentG = {
                
            }
        }
        }
    }
})

