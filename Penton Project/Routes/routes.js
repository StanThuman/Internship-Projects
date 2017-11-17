var express = require('express');
var app = express();
var router = express.Router();
var request = require('request');

var passport = require('passport');
var baseURL = 'http://localhost:3000';


router.get('/', (req, res) => {
  var userName = '';
  var isLoggedin = false;
  if(req.user){
    userName = req.user.firstName;
    isLoggedin = true;
  }
  res.render('index',{
    title: 'Home page',
    message: 'Hello There!',
    isSelected: true,
    firstName: userName,
    isLoggedin: isLoggedin

    });
});

router.get('/about', (req, res) => {
  var isLoggedin = false;
  var userName = '';
  if(req.user){
    userName = req.user.firstName;
    isLoggedin = true;
  }
  res.render('about', {
    title: 'About page',
    firstName: userName,
    isLoggedin: isLoggedin
  });
});

router.get('/addProfile', (req, res) => {
  res.render('addProfile', {
    title: 'Add Profile',
    formElements: [
      'First Name', 'Last Name', 'Age',
      'Height', 'BirthDate', 'Address',
      'Current Weight', 'Goal Weight', 'Calorie Goal'
    ]
  });
});

router.get('/createPost', (req, res) => {
  var userName = '';
  if(req.user){
    userName = req.user.firstName;
  }

  res.render('createPost', {title: 'Home page',
    firstName: userName
  });
});

router.get('/signup', (req, res) => {
  res.render('signup', {
    title: 'signup',
    formElements: [
      'First Name', 'Last Name', 'Age',
      'Height', 'BirthDate', 'Address',
    ]
  });
})
router.get('/login', (req, res) => {
  res.render('login', {
    title: 'Login'
  });
});

router.get('/logout', (req, res) => {
  req.logout();
  res.redirect('/');
});

router.get('/auth/google',
  passport.authenticate('google',{ scope: ['profile', 'email']}));

router.get('/auth/google/callback',
  passport.authenticate('google', {failureRedirect: '/exercise'}),
    (req, res) => {
      console.log("inside google auth callback");

      res.redirect('/');
    }
);



//client id 367318265696-jn0e1ss3pcup1283pb2b54jldb0rb3kj.apps.googleusercontent.com
//client secret H9beagWS8BL_67Y8bV4z45nz
// router.post('/login', passport.authenticate('local'), (req, res) => {
//
//   console.log('logging in');
// });




module.exports = router;
