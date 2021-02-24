/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 */

class Solution {
public:
    /** lowestCommonAncestor
      * Description: Searches a tree, with two nodes, and determines whas is the
      * lowest common ancestor or parent to both p and q
      * Inputs : TreeNode : root -> root of the tree
      *        : TreeNode : p is one child in the tree
      *        : TreeNode : q is another child in the tree
      * Output : Assumed : TreeNode : lca -> lowest common ancestor of p and q
      * Constraints : nodes in the tree range [2,10^5]
      *             : -10^0 <= Node.val <= 10^9
      *             : All Node.val = unique
      *             : p != q
      *             : p and  q exist in the BST
      
      * Data Structures / Algorithms : TreeNode (BST)
      * Time / Space complexity : inorder O(n) / O(1)
      * Test Case : easy : root = [6,2,8,0,null, null, null, null] given 2,8 : return 6
      *           : medium root =[6,2,8,0,4,7,9,null,null,3,5] given 2,4 : return 2
    **/
    TreeNode* lowestCommonAncestor(TreeNode* root, TreeNode* p, TreeNode* q) {
        if (root == NULL || p == NULL || q == NULL) return NULL;
        if (p->val < root->val && q->val < root->val) return lowestCommonAncestor(root->left, p, q);         
        if (p->val > root->val && q->val > root->val) return lowestCommonAncestor(root->right, p, q);
        return root;
    }

};
