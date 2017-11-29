var express = require('express');
var router = express.Router();
var Post = require('../db/models/post');
var Profile = require('../db/models/profile');

router.get('/', (req, res) => {
  var isLoggedin = false;
  if(req.user){
    isLoggedin = true;
  }
  Post.find({}).populate('author')
    .exec((err, posts) => {
      console.log(posts);
      res.render('post', {
        isLoggedin: isLoggedin,  
        posts:posts
      });

  });
});

router.get('/all', function(req,res){


});


router.post('/createPost', function(req, res){
  console.log(req.body);
  console.log('inside post post');
  var date = new Date();
  var month = date.getMonth();
  var day = date.getDay();
  if(month < 10){
    month = '0' + month;
  }
  if(day < 10){
    day = '0' + day;
  }
  var currentDate = month + '-' + day + '-' + date.getFullYear();
  var newPost = new Post({
    author: req.user._id,
    postTitle: req.body.postInput0,
    postMessage: req.body.postInput1,
    datePosted: currentDate,
    likes:0,
    dislikes: 0
  });
  newPost.save(err => {
    console.log("error saving")
    console.log(err);
  });
});

//profileRouter.get('/');


module.exports = router;
