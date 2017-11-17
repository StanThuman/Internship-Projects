var express = require('express');
var router = express.Router();
var Workout = require('../db/models/workout');
var getCurrentDate = require('../services/currentDate');
//var createProfile = require('../testData');

//var db = require('../config/connect');

router.get('/', (req, res) => {

  //console.log(req.user);
  var profileData = '';
  var userName = '';
  var isLoggedin = false;
  var currentDate = getCurrentDate();
  var previousWorkouts;
  var currentWorkouts;
  if(req.user){
    profileData = req.user;
    userName = req.user.firstName;
    isLoggedin = true;
  }
  // console.log('author: ' + req.user._id);
  // console.log('date: ' + currentDate);
  Workout.find({ author: req.user._id, date: currentDate })
    .populate({
      path: 'exercises',
      populate: {
        path:'exercises'
      }
    }).exec((err, workout) => {
      console.log('workout variable');
      console.log(workout);

      if(0 < workout.length){
        console.log('inside if');
        workout = workout[0].exercises;
        console.log(workout);


      }else{
        console.log('inside else');
      }

    res.render('userworkout', {
      title: 'User Info',
      profile: profileData,
      firstName: userName,
      isLoggedin: isLoggedin,
      workouts: workout

      });
  });
});

router.get('/edit', (req, res) => {
  var isLoggedIn = false;
  if(req.user){
    isLoggedin = true;
  }
  res.render('editWorkoutForm', {
    title: 'User Info',
    isLoggedin: isLoggedin
  });
});






router.get('/all', function(req,res){
  console.log('getting all the Exercise palns');

});

router.post('/edit', (req, res) => {

  var currentDate = getCurrentDate();

  Workout.findOne({ 'author': req.user._id, 'date': currentDate },
    (err, exercisePlan) => {
      if(err)
        console.log('there was an error');

      if(exercisePlan){
        console.log('found it')
        var newExercise = ({
          name: req.body.workoutInput1,
          duration: req.body.workoutInput2,
          type: req.body.workoutInput3,
          weight: req.body.workoutInput4,
          sets: req.body.workoutInput5,
          reps: req.body.workoutInput6
        });
        exercisePlan.exercises.push(newExercise);
        exercisePlan.save(err => {

          res.redirect('/profile/workout');
          if(err)
            console.log('error updating exercise into profile');
        });
        console.log('redirecting');
      }
      else{
        //create workout plan for current date
        var newWorkoutPlan = new Workout({
          author: req.user._id,
          exercises: [{
            name: req.body.workoutInput1,
            duration: req.body.workoutInput2,
            type: req.body.workoutInput3,
            weight: req.body.workoutInput4,
            sets: req.body.workoutInput5,
            reps: req.body.workoutInput6
          }],
          date: currentDate,
        });
        console.log(newWorkoutPlan);
        newWorkoutPlan.save(err => {
          if(err)
            console.log('error saving new workoutplan');
          else
            res.redirect('/profile/workout');

        });

      }

  });

});

//exerciseRouter.get('/');


module.exports = router;
