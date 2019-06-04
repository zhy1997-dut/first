clear all
clc
seed=1;
retest6=zeros(20,684);
seed_arr=randi([1,1000],20,1);
t3_arr=30*rand(20,1)+3;
k_arr=0.09*rand(20,1)+0.01;
for i=1:20
    seed=seed_arr(i,1);
    t3=t3_arr(i,1);
    k=k_arr(i,1);
    sim("testc3.slx");
    for j=1:684
        if yc6(j)>4
            yc6(j)=4;
        end
    end
    retest6(i,:)=yc6;
end
stairs(tout,retest6')
save retest6.mat retest6;