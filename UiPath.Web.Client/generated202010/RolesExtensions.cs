// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Roles.
    /// </summary>
    public static partial class RolesExtensions
    {
            /// <summary>
            /// Gets roles.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Read.
            ///
            /// Required permissions: Roles.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='top'>
            /// Limits the number of items returned from a collection. The maximum value is
            /// 1000.
            /// </param>
            /// <param name='skip'>
            /// Excludes the specified number of items of the queried collection from the
            /// result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            public static ODataValueOfIEnumerableOfRoleDto Get(this IRoles operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets roles.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Read.
            ///
            /// Required permissions: Roles.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='top'>
            /// Limits the number of items returned from a collection. The maximum value is
            /// 1000.
            /// </param>
            /// <param name='skip'>
            /// Excludes the specified number of items of the queried collection from the
            /// result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfRoleDto> GetAsync(this IRoles operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new role.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Write.
            ///
            /// Required permissions: Roles.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static RoleDto Post(this IRoles operations, RoleDto body = default(RoleDto))
            {
                return operations.PostAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new role.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Write.
            ///
            /// Required permissions: Roles.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleDto> PostAsync(this IRoles operations, RoleDto body = default(RoleDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets role based on its id.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Read.
            ///
            /// Required permissions: Roles.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            public static RoleDto GetById(this IRoles operations, int key, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(key, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets role based on its id.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Read.
            ///
            /// Required permissions: Roles.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleDto> GetByIdAsync(this IRoles operations, int key, string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(key, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Edits a role.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Write.
            ///
            /// Required permissions: Roles.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static RoleDto PutById(this IRoles operations, int key, RoleDto body = default(RoleDto))
            {
                return operations.PutByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Edits a role.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Write.
            ///
            /// Required permissions: Roles.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleDto> PutByIdAsync(this IRoles operations, int key, RoleDto body = default(RoleDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a role.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Write.
            ///
            /// Required permissions: Roles.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            public static void DeleteById(this IRoles operations, int key)
            {
                operations.DeleteByIdAsync(key).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a role.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Write.
            ///
            /// Required permissions: Roles.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IRoles operations, int key, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(key, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Associates a group of users with and dissociates another group of users
            /// from the given role.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Write.
            ///
            /// Required permissions: Roles.Edit and Users.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The role id.
            /// </param>
            /// <param name='body'>
            /// &lt;para /&gt;addedUserIds - The id of the users to be associated with the
            /// role.
            /// &lt;para /&gt;removedUserIds - The id of the users to be dissociated from
            /// the role.
            /// </param>
            public static void SetUsersById(this IRoles operations, int key, RolesSetUsersParameters body = default(RolesSetUsersParameters))
            {
                operations.SetUsersByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Associates a group of users with and dissociates another group of users
            /// from the given role.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Write.
            ///
            /// Required permissions: Roles.Edit and Users.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The role id.
            /// </param>
            /// <param name='body'>
            /// &lt;para /&gt;addedUserIds - The id of the users to be associated with the
            /// role.
            /// &lt;para /&gt;removedUserIds - The id of the users to be dissociated from
            /// the role.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SetUsersByIdAsync(this IRoles operations, int key, RolesSetUsersParameters body = default(RolesSetUsersParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SetUsersByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a collection of all the ids of the users associated to a role based
            /// on role Id.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Read.
            ///
            /// Required permissions: Roles.View or Users.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The Id of the role for which the robot ids are fetched.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            public static ODataValueOfIEnumerableOfInt64 GetUserIdsForRoleByKey(this IRoles operations, int key, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?))
            {
                return operations.GetUserIdsForRoleByKeyAsync(key, expand, filter, select, orderby, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a collection of all the ids of the users associated to a role based
            /// on role Id.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Read.
            ///
            /// Required permissions: Roles.View or Users.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The Id of the role for which the robot ids are fetched.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfInt64> GetUserIdsForRoleByKeyAsync(this IRoles operations, int key, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetUserIdsForRoleByKeyWithHttpMessagesAsync(key, expand, filter, select, orderby, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a collection of all users and, if no other sorting is provided,
            /// will place first those associated to a role.Allows odata query options.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Read.
            ///
            /// Required permissions: Roles.View and Users.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The Id of the role for which the associated users are placed first.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='top'>
            /// Limits the number of items returned from a collection. The maximum value is
            /// 1000.
            /// </param>
            /// <param name='skip'>
            /// Excludes the specified number of items of the queried collection from the
            /// result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            public static ODataValueOfIEnumerableOfUserDto GetUsersForRoleByKey(this IRoles operations, int key, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetUsersForRoleByKeyAsync(key, expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a collection of all users and, if no other sorting is provided,
            /// will place first those associated to a role.Allows odata query options.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Users or Users.Read.
            ///
            /// Required permissions: Roles.View and Users.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The Id of the role for which the associated users are placed first.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='top'>
            /// Limits the number of items returned from a collection. The maximum value is
            /// 1000.
            /// </param>
            /// <param name='skip'>
            /// Excludes the specified number of items of the queried collection from the
            /// result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfUserDto> GetUsersForRoleByKeyAsync(this IRoles operations, int key, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetUsersForRoleByKeyWithHttpMessagesAsync(key, expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}