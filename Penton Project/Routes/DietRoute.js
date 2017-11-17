var express = require('express');
var router = express.Router();
var Diet = require('../db/models/diet');
var getCurrentDate = require('../services/currentDate');
//var createProfile = require('../testData');

//var db = require('../config/connect');
var DietPlan = require('../db/models/diet');

router.get('/', (req, res) => {
  // console.log(req.user);
  var profileData = '';
  var userName = '';
  var isLoggedin = false;
  if(req.user){
    profileData = req.user;
      userName = req.user.firstName;
      isLoggedin = true;
  }
  res.render('userdiet', {
    title: 'User Info',
    profile: profileData,
    firstName: userName,
    isLoggedin: isLoggedin
  });
});

router.post('/addNewFood', (req,res) => {
  console.log(req.body.foodInput1);
  console.log(req.body.foodInput2);
  Diet.find({}, (err, diet) => {



  });

  res.redirect('/profile/diet');


});

router.get('/all', function(req,res){
  router.log('getting all the dietplans');

});

router.post('/addDietplan', function(req, res){
  console.log('adding exercise plan all the dietplans');
});

//exerciseRouter.get('/');

module.exports = router;
