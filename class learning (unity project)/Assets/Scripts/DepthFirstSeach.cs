using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthFirstSeach : MonoBehaviour
{
    public Node rootNode;
    public Node target;

    private void Start()
    {
        int stepCount = DFS(target);// call DFS method and store result in variable
        if (stepCount > -1)//check that result is great than -1 (target found)
        {
            Debug.Log(target.name +"was found in " + stepCount + " Step. ");
        }
        else// if result is -1, target node found
        {
            Debug.Log(target.name + "was not found. ");
        }
    }

    public int DFS(Node targetNode)
    {
        Stack stack = new Stack();  //stack the nodes, the last one stacked is the next one visited 
        List<Node> visitedNodes = new List<Node>(); // tracks the visited nodes 
     
        stack.Push(rootNode); // push the root node to the stack

        while (stack.Count > 0) // while the stack is not empty 
        {
            Node node = (Node)stack.Pop(); // get the last stack node 
            Debug.Log("");
            visitedNodes.Add(node); // visit the node

            foreach (Node child in node.children) // loop through the children of node
            {
                //if the child has not been visited or added to the stack
                if (visitedNodes.Contains(child) == false)
                {
                    if(child == targetNode) //target node found 
                    {
                        Debug.Log("target " + child.name + "found");
                        return visitedNodes.Count; //return number of visited nodes
                    }
                    stack.Push(child);
                }
            }
        }
        return -1;
    }
}
