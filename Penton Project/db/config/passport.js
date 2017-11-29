var GoogleStrategy = require('passport-google-oauth').OAuth2Strategy;
var Profile = require('../models/profile');

module.exports = (passport) => {
  // console.log('setting up passport');


  passport.serializeUser((user, done) => {
    // console.log('serializing');
    // console.log(user);
    done(null, user.google.id);
  });

  passport.deserializeUser((id, done) => {
    // console.log('deserializing');
    // console.log(id);
    Profile.findOne(id, (err, profile) => {
      //console.log(profile);
      done(err, profile);
    });
  });

  passport.use(new GoogleStrategy({
    clientID: '367318265696-jn0e1ss3pcup1283pb2b54jldb0rb3kj.apps.googleusercontent.com',
    clientSecret: '6p4Zm-eLV-_zp_omS9-FIrtl',
    callbackURL: 'http://localhost:3000/auth/google/callback'
  },
  (token, tokenSecret, gProfile, done) => {
    //find email
    Profile.findOne({'google.id' : gProfile.id},(err, profile) => {
      if(err)
        return done(err);

      if(profile){
        // console.log('found profile');
        //console.log(gProfile);
        return done(null, profile);
      }
      else{
        // var newUserProfile = new Profile({
        //   google:{
        //     id: gProfile.id,
        //     name: gProfile.name
        //   },
        //   firstName: gProfile.name.givenName,
        //   lastName: gProfile.name.familyName,
        //   age: faker.random.number(),
        //   height: faker.random.number(),
        //   birthDate: faker.date.recent(),
        //   Address: faker.address.streetAddress(),
        //
        // });

        return done();
      }



    });
    console.log('inside google strategy');
  }));
}
