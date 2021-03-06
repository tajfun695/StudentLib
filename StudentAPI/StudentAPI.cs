﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAPI
{
    public static class StudentAPI
    {
        #region Object/ObjectList
        
        /// <summary>
        /// [SYNC]Setting session by access token from provider.
        /// </summary>
        /// <param name="auth_provider">Name of provider</param>
        /// <param name="accessToken">Access Token</param>
        /// <returns></returns>
        public static bool SetSession(string auth_provider, string accessToken) => Task.Run(() => Libs.StudentAPI.SetSession(auth_provider, accessToken)).Result;

        /// <summary>
        /// [ASYNC] Setting sesion by access token from provider.
        /// </summary>
        /// <param name="auth_provider">Name of provider</param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public static async Task<bool> SetSessionAsync(string auth_provider, string accessToken) => await Libs.StudentAPI.SetSession(auth_provider, accessToken);

        /// <summary>
        /// [SYNC] Giving information about currnet user
        /// </summary>
        /// <returns></returns>
        public static Models.API.User GetUserObject() => Task.Run(() => Libs.StudentAPI.GetUserObject()).Result;

        /// <summary>
        /// [ASYNC] Giving information about currnet user
        /// </summary>
        /// <returns></returns>
        public static async Task<Models.API.User> GetUserObjectAsync() => await Libs.StudentAPI.GetUserObject();

        /// <summary>
        /// [SYNC]Giving list of colleges and information
        /// </summary>
        /// <param name="pattern">Patter of name college.</param>
        /// <returns></returns>
        public static List<Models.API.Collage.College> GetCollegeList(string pattern = null) => Task.Run(() => Libs.StudentAPI.GetCollegeListObject(pattern)).Result;

        /// <summary>
        /// [ASYNC]Giving list of colleges and information
        /// </summary>
        /// <param name="pattern">Patter of name college.</param>
        /// <returns></returns>
        public static async Task<List<Models.API.Collage.College>> GetCollegeListAsync(string pattern = null) => await Libs.StudentAPI.GetCollegeListObject(pattern);

        /// <summary>
        /// [SYNC]Giving list of departments and information
        /// </summary>
        /// <param name="ID">College`s ID</param>
        /// <returns></returns>
        public static List<Models.API.Deparment.Department> GetDepartmentList(int ID) => Task.Run(() => Libs.StudentAPI.GetDepartmentObject(ID)).Result;

        /// <summary>
        /// [ASYNC]Giving list of departments and information
        /// </summary>
        /// <param name="ID">College`s ID</param>
        /// <returns></returns>
        public static async Task<List<Models.API.Deparment.Department>> GetDepartmentListAsync(int ID) => await Libs.StudentAPI.GetDepartmentObject(ID);

        /// <summary>
        /// [SYNC] Giving list of categories and information
        /// </summary>
        /// <param name="ID">ID of department</param>
        /// <returns></returns>
        public static List<Models.API.Categorie.Categorie> GetCategoriesList(int ID) => Task.Run(() => Libs.StudentAPI.GetCategorieObject(ID)).Result;

        /// <summary>
        /// [ASYNC] Giving list of categories and information
        /// </summary>
        /// <param name="ID">ID of department</param>
        /// <returns></returns>
        public static async Task<List<Models.API.Categorie.Categorie>> GetCategoriesListAsync(int ID) => await Libs.StudentAPI.GetCategorieObject(ID);

        /// <summary>
        /// [SYNC] GET CURESES LIST!
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static List<Models.API.Courses.Course> GetCoursesList(int ID) => Task.Run(() => Libs.StudentAPI.GetCursesObject(ID)).Result;

        /// <summary>
        /// [ASYNC] GET CURESES LIST!
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static async Task<List<Models.API.Courses.Course>> GetCoursesListAsync(int ID) => await Libs.StudentAPI.GetCursesObject(ID);

        /// <summary>
        /// [SYNC] GET THREAD LIST IN COURSE!
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Models.API.Threads.ThreadsGroup GetThreadsList(int ID) => Task.Run(() => Libs.StudentAPI.GetThreadList(ID)).Result;

        /// <summary>
        /// [ASYNC] GET THREAD LIST IN COURSE!
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static async Task<Models.API.Threads.ThreadsGroup> GetThreadsListAsync(int ID) => await Libs.StudentAPI.GetThreadList(ID);

        /// <summary>
        /// [SYNC] GET POSTS LIST IN CURSE!
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="OP"></param>
        /// <returns></returns>
        public static List<Models.API.PostComent.Post> GetPostList(int ID, int OP) => Task.Run(() => Libs.StudentAPI.GetPostList(ID, OP)).Result;

        /// <summary>
        /// [ASYNC] GET POSTS LIST IN THREAD!
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="OP"></param>
        /// <returns></returns>
        public static async Task<List<Models.API.PostComent.Post>> GetPostListAsync(int ID, int OP) => await Libs.StudentAPI.GetPostList(ID, OP);

        /// <summary>
        /// [SYNC] GET COMMENTS LIST IN POST!
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static List<Models.API.PostComent.CommentList> GetCommentsList(int ID) => Task.Run(() => Libs.StudentAPI.GetCommentList(ID)).Result;

        /// <summary>
        /// [ASYNC] GET COMMENTS LIST IN POST!
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static async Task<List<Models.API.PostComent.CommentList>> GetCommentsListAsync(int ID) => await Libs.StudentAPI.GetCommentList(ID);

        /// <summary>
        /// [SYNC] GET LIST OF GROUP MEMBERS 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static List<Models.API.Group.GroupMembers> GetMemberList(int ID) => Task.Run(() => Libs.StudentAPI.GetMemberList(ID)).Result;

        /// <summary>
        /// [ASYNC] GET LIST OF GROUP MEMBERS
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static async Task<List<Models.API.Group.GroupMembers>> GetMemberListAsync(int ID) => await Libs.StudentAPI.GetMemberList(ID);

        /// <summary>
        /// [SYNC] GET LIST OF GROUPS
        /// </summary>
        /// <returns></returns>
        public static List<Models.API.Group.Groups> GetMyGroupsList() => Task.Run(() => Libs.StudentAPI.GetCurrentGroup()).Result;

        /// <summary>
        /// [ASYNC] GET LIST OF GROUPS
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static async Task<List<Models.API.Group.Groups>> GetMyGroupsListAsync() => await Libs.StudentAPI.GetCurrentGroup();

        /// <summary>
        /// [ASYNC] Search in colleges, deparmetns, groups, users
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public static async Task<Models.API.Search> Search(string searchString) => await Libs.StudentAPI.Search(searchString);

        #endregion

        #region CreateMethods

        /// <summary>
        /// Create new college in database
        /// </summary>
        /// <param name="name">The name of college</param>
        /// <param name="alias">The alias for this college</param>
        /// <param name="description">Short discription for college</param>
        public static void CreateCollege(string name, List<string> alias, string description) => Libs.StudentAPI.CreateCollege(name, alias, description);

        /// <summary>
        /// Create new department for selected college
        /// </summary>
        /// <param name="name">The name of department</param>
        /// <param name="college_id">College`s ID</param>
        /// <param name="description">Short desciprion of department</param>
        public static void CreateDepartment(string name, int college_id, string description) => Libs.StudentAPI.CreateDepartment(name, college_id, description);

        /// <summary>
        /// Create new categorie for selected department
        /// </summary>
        /// <param name="name">Name of categories</param>
        /// <param name="department_id">Department`s ID</param>
        public static void CreateCategorie(string name, int department_id) => Libs.StudentAPI.CreateCategories(name, department_id);

        /// <summary>
        /// Create curses for selected categories
        /// </summary>
        /// <param name="name">Name of curses</param>
        /// <param name="category_id">Categoried`s ID</param>
        public static void CreateCurses(string name, int category_id) => Libs.StudentAPI.CreateCourse(name, category_id);

        /// <summary>
        /// Create thread for selected curses
        /// </summary>
        /// <param name="group_id">Curse`s ID</param>
        /// <param name="title">Title of thread</param>
        /// <param name="isPinned"></param>
        public static void CreateThread(int group_id, string title, bool isPinned) => Libs.StudentAPI.CreateThread(group_id, title, isPinned);

        /// <summary>
        /// Create post for selected thread
        /// </summary>
        /// <param name="thread_id">Thread`s ID</param>
        /// <param name="message">Message in post</param>
        public static void CreatePost(int thread_id, string message) => Libs.StudentAPI.CreatePost(thread_id, message);

        /// <summary>
        /// Create commend for selected post
        /// </summary>
        /// <param name="post_id">Post`s ID</param>
        /// <param name="message">Message of comment</param>
        public static void CreatComment(int post_id, string message) => Libs.StudentAPI.CreateComment(post_id, message);

        /// <summary>
        /// Joining to selected curses/group
        /// </summary>
        /// <param name="group_id">Course`s ID/Group`s ID</param>
        public static void JoinToGroup(int group_id) => Libs.StudentAPI.JoinToGroup(group_id);

        #endregion

        #region EditMethods

        /// <summary>
        /// Edit post!
        /// </summary>
        /// <param name="post_id">Post`s ID</param>
        /// <param name="content">New message for post</param>
        public static void EditPost(int post_id, string content) => Libs.StudentAPI.EditPost(post_id, content);

        /// <summary>
        /// Edit user profile who is sign in right now.
        /// </summary>
        /// <param name="name">New nickname</param>
        /// <param name="first">First name</param>
        /// <param name="middle">Middle name</param>
        /// <param name="lastname">Surname</param>
        /// <param name="gender">Gender of user</param>
        public static void EditProfile(string name, string first, string middle, string lastname, string gender) => Libs.StudentAPI.EditProfile(name, first, middle, lastname, gender);

        #endregion

        #region DeleteMethods

        /// <summary>
        /// Deleting selected post
        /// </summary>
        /// <param name="ID">POST`ID</param>
        public static void DeletePost(int ID) => Libs.StudentAPI.DeletePost(ID);

        /// <summary>
        /// Leave from selected group
        /// </summary>
        /// <param name="groupID">Group`s ID</param>
        /// <param name="memberID">User`s ID or member</param>
        public static void LeaveFromGroup(int groupID, int memberID) => Libs.StudentAPI.LeaveFormGroup(groupID, memberID);

        #endregion

        #region Settings

        /// <summary>
        /// Showing information about new user.
        /// </summary>
        /// <returns></returns>
        public static bool IsNew() => Libs.StudentAPI.isNew();
        #endregion

    }
}
